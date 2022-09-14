using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace TCP_CLIENT_CHAT {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            receiveData = new Thread(func_receiveData);
        }

        TcpClient client;
        Thread receiveData;
        bool connected = false;
        NetworkStream nsStream;
        bool selfSend = false, selfConnect = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (connected) {
                client.Close();
                nsStream.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.Size = new System.Drawing.Size(192, Height);
            tbIP.ForeColor = Color.Gray;
            tbIP.Text = "Indirizzo IP";
            tbNameClient.ForeColor = Color.Gray;
            tbNameClient.Text = "Nome Client";

        }

        private void btnConnetti_Click(object sender, EventArgs e) {
            try { //provo a connettermi, se fallisce, genera un'eccezione che verrà mostrata con messagebox
                if (tbNameClient.Text != "Nome Client" && !tbNameClient.Text.Contains(" ")) { //se contiene spazi o la textbox è vuota, il nome non è valido
                    if (!connected) {
                        client = new TcpClient(tbIP.Text, 52001); //creo un nuovo client con ip e porta citati
                        nsStream = client.GetStream(); //ottengo lo stream send/receive per il client
                        sendToServer(DateTime.Now.ToString("HH:mm:ss") + '|' + "#connect" + '|' + tbNameClient.Text + '|' + " sì è connesso!");

                        setForm(true);
                        selfConnect = true;
                        connected = true;
                        this.Size = new System.Drawing.Size(750, Height); //imposto la larghezza della form in modo da vedere la chat
                        if (receiveData.ThreadState != ThreadState.Running) { receiveData.Start(); } //se il thread per ricevere dal server non è attivo, lo avvio
                    } else {
                        showMessageBox("Sei già connesso al server!");
                    }
                } else {
                    showMessageBox("Nome non valido!");
                }
            } catch (Exception ex) {
                showMessageBox(ex.Message);
            }
        }
        private void btnSendMessage_Click(object sender, EventArgs e) {
            if (tbMessage.Text != string.Empty) {
                selfSend = true;
                sendToServer(DateTime.Now.ToString("HH:mm:ss") + '|' + "#send" + '|' + tbNameClient.Text + '|' + tbMessage.Text);
                tbMessage.Text = string.Empty;
            } else {
                showMessageBox("Impossibile lasciare il campo vuoto");
            }
        }

        //metodi
        private void addToListBox(string msg) {
            lbChat.Items.Add(msg);
        }
        private void sendToServer(string msg) {
            try {
                byte[] buffer = Encoding.ASCII.GetBytes(msg);
                nsStream.Write(buffer, 0, buffer.Length); //decodifico una stringa in bytes da inviare al server
                //il messaggio che invio contine data, comando, nome client e messaggio, separati da pipe line '|'
                //ci penserà il server a gestire il tutto
            } catch (Exception ex) {
                showMessageBox(ex.Message);
            }
        }
        private void func_receiveData() {
            try { //avvio un thread per ogni client che si connette, ricevo i dati li decodifico e verico la stringa con lo split
                while (true) {
                    NetworkStream nsStream = client.GetStream(); //ottengo per ogni client connesso uno stream dati
                    byte[] receivedBytes = new byte[1024];
                    int byte_count = nsStream.Read(receivedBytes, 0, receivedBytes.Length);
                    if (byte_count == 0) { break; } //se non ricevo più nulla, esco dal ciclo

                    string data = Encoding.ASCII.GetString(receivedBytes, 0, byte_count); //decodifico i bytes in una stringa
                    string[] splitData = data.Split('|');
                    checkSplitData(splitData); //la stringa originale contiene: ora attuale, comando, nome del client e messaggio inviato
                }
                client.GetStream().Close(); //chiudo il client quando la connessione viene interrotta
                client.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkSplitData(string[] splitData) {
            if (splitData[1] == "#connect") { //se un client si connette invia "#connect" così da stampare nella listbox "client x sì è connesso"
                if (selfConnect && tbNameClient.Text == splitData[2]) {
                    //quando si preme invia il bool selfSend diventa =true in modo da capire che non è un client esterno quello che si è connesso,
                    //ma quello che sto utilizzando in questo pc, e se il nome della textbox inerente al nome è uguale alla stringa splittata del medesimo,
                    //allora sono IO che mi sono connesso/inviando messaggi, quindi stampo "Hai detto/Ti sei connesso" ecc.
                    addToListBox(splitData[0] + " -> " + "Ti sei connesso al server!");
                } else { addToListBox(splitData[0] + " -> " + splitData[2] + " si e' connesso!"); }
            } else if (splitData[1] == "#send") { //comando per capire che il client ha inviato un messaggio
                if (selfSend && tbNameClient.Text == splitData[2]) { //leggere riga 107-109
                    addToListBox(splitData[0] + " -> " + "Hai detto: " + splitData[3]);
                } else { addToListBox(splitData[0] + " -> " + splitData[2] + ": " + splitData[3]); }
            } else if (splitData[1] == "#close") {
                client.Close();
                nsStream.Close();
                setForm(false);
            } else if (splitData[1] == "#file") {
                addToListBox(splitData[0] + " -> " + "File inviato con successo!");
            }
        }
        private void setForm(bool b) {
            if (b) { //quando mi connetto, disabilito/abilito i seguneti componeneti in base a quello che mi server 
                tbNameClient.Enabled = false;
                tbIP.Enabled = false;
                pChat.Enabled = true;
            } else {
                btnConnetti.Enabled = true;
                tbNameClient.Enabled = true;
                pChat.Enabled = false;
            }
        }
        private void showMessageBox(string text) {
            MessageBox.Show(text, "Client - " + tbNameClient.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //fine metodi


        //placeholder textbox
        private void tbIP_Click(object sender, EventArgs e) {
            setTextBoxIP();
        }
        private void tbNameClient_Click(object sender, EventArgs e) {
            setTextBoxNameClient();
        }

        private void setTextBoxNameClient() {
            if (tbNameClient.Text == "Nome Client") {  //simulo un placeholder (textbox con testo di aiuto)
                tbNameClient.ForeColor = Color.Black;
                tbNameClient.Text = string.Empty;
            } else if (tbNameClient.Text != "Nome Client") {
                //se clicco nuovamente questa textbox ed è scritto un nome, non rimuovo la stringa
            } else {
                tbNameClient.ForeColor = Color.Gray;
                tbNameClient.Text = "Nome Client";
            }
        }

        private void setTextBoxIP() {
            if (tbIP.Text == "Indirizzo IP") {  //simulo un placeholder (textbox con testo di aiuto)
                tbIP.ForeColor = Color.Black;
                tbIP.Text = string.Empty;
            } else if (tbIP.Text != "Indirizzo IP") {
                //se clicco nuovamente questa textbox ed è scritto un nome, non rimuovo la stringa
            } else {
                tbIP.ForeColor = Color.Gray;
                tbIP.Text = "Indirizzo IP";
            }
        }
    }
}
