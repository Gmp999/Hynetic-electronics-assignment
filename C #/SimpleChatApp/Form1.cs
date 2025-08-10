using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleChatApp
{
    public partial class Form1 : Form
    {
        TcpClient client;
        TcpListener server;
        NetworkStream stream;
        Thread receiveThread;
        TextBox txtChat;
        TextBox txtMessage;
        Button btnSend;
        Button btnStartServer;
        Button btnConnect;


        public Form1()
        {

            InitializeComponent();
            // Chat display
            txtChat = new TextBox();
            txtChat.Multiline = true;
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Width = 380;
            txtChat.Height = 200;
            txtChat.Top = 10;
            txtChat.Left = 10;
            this.Controls.Add(txtChat);

            // Message box
            txtMessage = new TextBox();
            txtMessage.Top = 220;
            txtMessage.Left = 10;
            txtMessage.Width = 300;
            this.Controls.Add(txtMessage);

            // Send button
            btnSend = new Button();
            btnSend.Text = "Send";
            btnSend.Top = 220;
            btnSend.Left = 320;
            btnSend.Click += btnSend_Click;
            this.Controls.Add(btnSend);

            // Start Server button
            btnStartServer = new Button();
            btnStartServer.Text = "Start Server";
            btnStartServer.Top = 260;
            btnStartServer.Left = 10;
            btnStartServer.Click += btnStartServer_Click;
            this.Controls.Add(btnStartServer);

            // Connect button
            btnConnect = new Button();
            btnConnect.Text = "Connect to Server";
            btnConnect.Top = 260;
            btnConnect.Left = 120;
            btnConnect.Click += btnConnect_Click;
            this.Controls.Add(btnConnect);

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 5000);
                server.Start();
                AppendText("Server started. Waiting for client...\n");

                Thread acceptThread = new Thread(() =>
                {
                    client = server.AcceptTcpClient();
                    stream = client.GetStream();
                    AppendText("Client connected.\n");
                    StartReceiving();
                });
                acceptThread.IsBackground = true;
                acceptThread.Start();
            }
            catch (Exception ex)
            {
                AppendText($"Error: {ex.Message}\n");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 5000); // connect to localhost
                stream = client.GetStream();
                AppendText("Connected to server.\n");
                StartReceiving();
            }
            catch (Exception ex)
            {
                AppendText($"Error: {ex.Message}\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (stream != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                    stream.Write(data, 0, data.Length);
                    AppendText("Me: " + txtMessage.Text + "\n");
                    txtMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                AppendText($"Error: {ex.Message}\n");
            }
        }

        private void StartReceiving()
        {
            receiveThread = new Thread(() =>
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        AppendText("Friend: " + message + "\n");
                    }
                }
                catch { }
            });
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendText), text);
                return;
            }
            txtChat.AppendText(text);
        }
    }
}

