using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MES_ScaleReadings.Desktop
{
    public partial class Form1 : Form
    {
        //Server server = new Server();
        public string Rx_Data;
        public TcpClient tcpClient100;
        public IAsyncResult asResult100;
        public TcpClient tcpClient101;
        public IAsyncResult asResult101;

        public event EventHandler Received;
        public Form1()
        {
            InitializeComponent();
            //server.Received += new EventHandler(server_Received);
        }

        //public void server_Received(object sender, EventArgs e)
        //{
        //    //tbInfo.Text = server.Rx_Data;
        //}

        //public static void Connect(string server, int port)
        //{
        //    try
        //    {
        //        TcpClient client = new TcpClient(server, port);

        //        var data = Encoding.ASCII.GetBytes("S");

        //        var stream = client.GetStream();

        //        data = new byte[257];

        //        var responseData = string.Empty;

        //        var bytes = stream.Read(data, 0, data.Length);
        //        responseData = Encoding.ASCII.GetString(data, 0, bytes);

        //        var msgStr = string.Format("Received: {0} ", responseData);
        //        MessageBox.Show(msgStr);

        //        stream.Close();
        //        client.Close();
        //    }
        //    catch (ArgumentNullException e)
        //    {
        //        MessageBox.Show("ArgumentNullException: {0}" + e.Message);
        //    }
        //    catch (SocketException e)
        //    {
        //        MessageBox.Show("SocketException: {0}" + e.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //} // Connect

        private void button1_Click(object sender, EventArgs e)
        {
            GetScaleReading("10.10.1.100", 0);
            //tbInfo100.Text = string.Empty;
            //tbInfo101.Text = string.Empty;


            //tcpClient100 = new TcpClient("10.10.1.100", 1);
            //asResult100 = HandleClientCommAsync100("10.10.1.100", 1);

            //tcpClient101 = new TcpClient("10.10.1.101", 1);
            //asResult101 = HandleClientCommAsync101("10.10.1.101", 1);
        }

        protected virtual void IsDataReceived(EventArgs e)
        {
            if (Received != null)
                Received(this, e);
        }

        private async System.Threading.Tasks.Task HandleClientCommAsync100(string server, int port)
        {
            var clientStream100 = tcpClient100.GetStream();
            var encoder = new ASCIIEncoding();

            byte[] message = new byte[4096];
            int bytesRead;

            while (tcpClient100.Connected)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = await clientStream100.ReadAsync(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                var str = encoder.GetString(message, 0, bytesRead);
                //if (decimal.Parse(Regex.Match(str.Substring(20, str.Length - 20).Trim(), @"\d+.+\d").Value) > 0)
                //{
                    tbInfo100.Text += "IP: " + tcpClient100.Client.RemoteEndPoint + "   Weight: " + Regex.Match(str.Substring(20, str.Length - 20).Trim(), @"-?\d+.+\d").Value + Environment.NewLine;
                    tbInfo100.Refresh();
                //}

                IsDataReceived(EventArgs.Empty);
            }
        }

        private async System.Threading.Tasks.Task HandleClientCommAsync101(string server, int port)
        {
            var clientStream101 = tcpClient101.GetStream();
            var encoder1 = new ASCIIEncoding();

            byte[] message1 = new byte[4096];
            int bytesRead1;

            while (tcpClient101.Connected)
            {
                bytesRead1 = 0;

                try
                {
                    bytesRead1 = await clientStream101.ReadAsync(message1, 0, 4096);
                }
                catch
                {
                    break;
                }

                var str1 = encoder1.GetString(message1, 0, bytesRead1);
                //if (decimal.Parse(Regex.Match(str1.Substring(20, str1.Length - 20).Trim(), @"\d+.+\d").Value) > 0)
                //{
                    tbInfo101.Text += "IP: " + tcpClient101.Client.RemoteEndPoint + "   Weight: " + Regex.Match(str1.Substring(20, str1.Length - 20).Trim(), @"-?\d+.+\d").Value + Environment.NewLine;
                    tbInfo101.Refresh();
                //}

                IsDataReceived(EventArgs.Empty);
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            tbInfo100.Text = string.Empty;
            tbInfo101.Text = string.Empty;
            //tcpClient100.Close();
            //tcpClient101.Close();
        }

        private void GetScaleReading(string ip, int port)
        {
            TcpClient client = new TcpClient();
            try
            {

                var PORT_NO = port;           //enter the scale IP port number
                var SERVER_IP = ip;   //enter the scale IP address
                                      //---data to send to the server---

                //---create a TCPClient object at the IP and port no.---
                client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();

                byte[] ENQByteToSend = new byte[1];
                ENQByteToSend[0] = 5; //put an ENQ (char(5)) into the byte array

                //---send the ENQ---

                //this.Controls.Find(string.Format("tbInfo10{0}", i), false).First().Text += "Sending : " + ENQByteToSend[0] + Environment.NewLine;

                nwStream.Write(ENQByteToSend, 0, ENQByteToSend.Length);

                //---read back the text--- //this could be the weight data
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                var str1 = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead) + Environment.NewLine; //"G 11-05-22 19:15:10      0.018 kg";//
                var res = Regex.Match(str1.Substring(20, str1.Length - 20).Trim(), @"-?\d+.+\d").Value + Environment.NewLine;

                //var lblUOM = "G";
                //if (lblUOM == "G")
                //{
                //    res = (decimal.Parse(res) * 1000).ToString();
                //}


                this.Controls.Find(string.Format("tbInfo10{0}", 0), false).First().Text += "Received : IP: " + ip + " : " + res + Environment.NewLine;

                //Console.ReadLine();
                client.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.Close();
            }
        }

        private void btnGet101_Click(object sender, EventArgs e)
        {
            GetScaleReading("10.10.1.101", 1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetScaleReading(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }

        //        IDictionary<Task<TcpClient>, Tuple<int, TcpListener>> tcpListeners = new Dictionary<Task<TcpClient>, Tuple<int, TcpListener>>();

        //foreach (var port in Enumerable.Range(20000, 5))
        //{
        //    var tcpListener = new TcpListener(IPAddress.Any, port);

        //        tcpListener.Start();

        //    var task = tcpListener.AcceptTcpClientAsync();
        //        var tcpListenerPortPair = new Tuple<int, TcpListener>(port, tcpListener);

        //        tcpListeners.Add(task, tcpListenerPortPair);
        //}

        //    Task<TcpClient> tcpClientTask;

        //while ((tcpClientTask = await Task.WhenAny(tcpListeners.Keys)) != null)
        //{
        //    var tcpListenerPortPair = tcpListeners[tcpClientTask];
        //    var port = tcpListenerPortPair.Item1;
        //    var tcpListener = tcpListenerPortPair.Item2;

        //    tcpListeners.Remove(tcpClientTask);

        //    // This needs to be async. What to do with its Task?
        //    // It cannot be awaited here.
        //    var handlerTask = HandleByPortNumber(tcpClientTask.Result, port);

        //    var task = tcpListener.AcceptTcpClientAsync();

        //    tcpListeners.Add(task, tcpListenerPortPair);
        //}




    }
}




