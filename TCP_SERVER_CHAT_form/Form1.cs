using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace TCP_SERVER_CHAT_form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            acceptConnection = new Thread(func_acceptConnection);
        }

        int countClient = 1;
        bool started = false;
        static readonly Dictionary<int, TcpClient> listaClient = new Dictionary<int, TcpClient>();

        TcpListener server;
        Thread acceptConnection;
        private void btnStartServer_Click(object sender, EventArgs e) {
            if (!started) { //se il server non è partito, allora lo avvio poichè non è possibile avviarne più di uno su stesso endpoint
                server = new TcpListener(IPAddress.Parse(cbIP.Text), 52001); //creo un server che ascolta le connessioni in entrata
                server.Start();
                started = true;
                this.Size = new System.Drawing.Size(886, Height);
                acceptConnection.Start(); //avvio il thread loop infinito per accettare continuamente connessioni da parte di client
                lbLog.Items.Add("Server avviato, attendo connessioni...");
            } else {
                showMessageBox("Il server è gia in funzione!");
            }
        }

        //metodi
        private void func_acceptConnection() {
            while (true) { //ciclo infinito per permettere di accettare più connessioni da client diversi
                TcpClient client = server.AcceptTcpClient();
                listaClient.Add(countClient, client); //aggiundo alla dict idClient(int) e client, in modo da poterli gestire uno ad uno, volendo

                Thread thread = new Thread(handleClient);
                thread.Start(countClient); //Thread parametrizzato con id del client (int)
                countClient++;
            }
        }
        private void handleClient(object o) {
            try {
                int readBytes;
                byte[] sendBuffer = new byte[1024];
                int idClient = (int)o; TcpClient client; //cast dell'oggetto passato in intero
                client = listaClient[idClient]; //assegno al client il suo id quando si collega al server
                NetworkStream netStream = client.GetStream(); //ottengo la stream send/receive del client
                while ((readBytes = netStream.Read(sendBuffer, 0, sendBuffer.Length)) != 0) { //finchè i bytes in lettura non sono diversi da 0, praticamente a connessione chiusa, continua a decodificare il buffer in arrivo
                    string data = Encoding.ASCII.GetString(sendBuffer, 0, readBytes);
                    string[] splitData = data.Split('|'); //split[0-3], [0] data attuale, [1] comando (es. #connect, #send), [2] nomeClient, [3] messaggio
                    sendToAllClient(data); //invio ai Client
                    checkSplitData(splitData, client); //verifico i comandi arrivati dai client
                }
                listaClient.Remove(idClient); //rimuovo un client dalla dict se si disconnette, inutile pochè non gestico disconnesioni
                client.Client.Shutdown(SocketShutdown.Both);
                client.Close();
            } catch (Exception ex) {
                showMessageBox(ex.Message);
            }
        }
        private void sendToAllClient(string data) {
            byte[] sendBuffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);
            foreach (TcpClient c in listaClient.Values) {
                //per ogni client nella dict, invio la stringa NON splittata (quindi intera) che invio a riga 60, gesirà il client poi lo split
                NetworkStream netStream = c.GetStream();
                netStream.Write(sendBuffer, 0, sendBuffer.Length);
            }
        }
        private void checkSplitData(string[] splitData, TcpClient client) {
            //gestico la string splittata in arrivo, vedere riga 106-123 in poi del Client.cs
            if (splitData[1] == "#connect") {
                lbLog.Items.Add(splitData[0] + " -> " + splitData[2] + " si e' connesso!");
                lbClient.Items.Add(client.Client.RemoteEndPoint + " (" + splitData[2] + ")");
            } else if (splitData[1] == "#send") {
                lbLog.Items.Add(splitData[0] + " -> " + splitData[2] + ": " + splitData[3]);
            } else if (splitData[1] == "#disconnect") {
                lbLog.Items.Add(splitData[0] + " -> " + splitData[2] + " sì è disconnesso!");
            }
        }
        private void showMessageBox(string text) {
            MessageBox.Show(text, "Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e) {
            var host = Dns.GetHostEntry(Dns.GetHostName()); //all'avvio del programma, prendo tutti gli ip della scheda di rete presente nella macchina
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    cbIP.Items.Add(ip.ToString());
                }
            }
            cbIP.Items.Add("127.0.0.1"); //aggiungo l'ip locale
            cbIP.SelectedIndex = 0; //seleziono sempre il primo
            this.Size = new System.Drawing.Size(192, Height);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (started) { //fermo il server quando la form viene chiusa per evitare il funzionamento in background
                server.Stop();
            }
        }
    }
}
