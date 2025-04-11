using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
           
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(listen));
            t.Start();
        }

        public void listen()
        {
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.3"), 8080);
                TcpListener server = new TcpListener(ipe);
                server.Start();

                //Phia client
                TcpClient client = server.AcceptTcpClient();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                int kq = 0;
                while (true)
                {
                    if (server.Pending())
                    {
                        string s = sr.ReadLine();
                        if (s.ToUpper().Equals("QUIT")) break;
                        string[] arr = s.Split('#');
                        int a = int.Parse(arr[0]);
                        int b = int.Parse(arr[2]);
                        switch (arr[1])
                        {
                            case "cộng": kq = (a + b); break;
                            case "trừ": kq = (a - b); break;
                            case "nhân": kq = (a * b); break;
                            case "chia": kq = (a / b); break;
                            default: kq = 0; break;
                        }
                        sw.WriteLine(kq.ToString());
                        sw.Flush();
                    }
                }
                sr.Close(); ;
                sw.Close();
                client.Close();
                server.Stop();
            }
            catch (Exception ex) { }
        }
    }
}
