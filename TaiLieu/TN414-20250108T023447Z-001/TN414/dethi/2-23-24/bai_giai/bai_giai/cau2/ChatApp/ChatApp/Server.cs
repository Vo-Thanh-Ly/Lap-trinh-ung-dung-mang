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

namespace ChatApp
{
    public partial class Server : Form
    {
        TcpListener Listener;
        int portN;
        String rootDir="F:/";
        public Server()
        {
            InitializeComponent();
        }
        private delegate void dlgAddInfo(string str);
        private void AddInfo(string str)
        {
            if (this.rtxInfo.InvokeRequired)
            { this.Invoke(new dlgAddInfo(AddInfo), str); }
            else
            { this.rtxInfo.AppendText(str+"\n\r"); }
        }        
        private void CreJob(String[] request, StreamWriter sw)
        { //acc key pass message            
            String s = "100. Tin nhan luu thanh cong";
            string fileName = rootDir +request[1]+"_"+ request[2] + ".txt";
            try
            {
                File.WriteAllText(fileName, request[3]);                
            }
            catch(Exception ex)
            {
                s = "203. Khong the luu tin nhan.";
            }
            sw.WriteLine(s);
            sw.Flush();
        }
        private void ReaJob(String[] request, StreamWriter sw)
        {       
            string[] files = Directory.GetFiles(rootDir);
            String s = "205. Tin nhan khong ton tai.";
            foreach (string file in files)
            {
                if (Path.GetFileName(file).StartsWith(request[1]))
                    {
                    s = "204. Sai mat khau.";
                    string fileName = rootDir + request[1] + "_" + request[2] + ".txt";
                    if (File.Exists(fileName))
                    {
                        String[] lines = File.ReadAllLines(fileName);
                        s = String.Join(" ", lines);
                        break;
                    }
                }    
            }         
            sw.WriteLine(s);
            sw.Flush();
        }
        private void UndefinedCommand(String[] request, StreamWriter sw)
        {
            String s = "Lỗi. Lệnh không tồn tại:"+ request[0];
            byte[] data = new byte[s.Length];
            sw.Write(s, 0, s.Length);
            sw.Flush();
        }
        private void ThreadProc(object obj)
        {
            try { 
            var client = (TcpClient)obj;
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine("Chao mung ket noi toi SecretBox");
            sw.Flush();
            while (true)
            {
                string raw = sr.ReadLine();
                string[] request = raw.Split('#');
                AddInfo("Client Command:"+raw);
                string command = "";
                if (request.Length != 0)
                    command = request[0];
                switch (command.ToUpper().Trim())
                {                    
                    case "CRE"://tạo tin nhắn
                        {
                            CreJob(request, sw);
                            break;
                        }
                    case "REA"://đọc tin tin
                        {
                            ReaJob(request, sw);
                            break;
                        }
                    default:
                        {
                            UndefinedCommand(request, sw);
                            break;
                        }
                }
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ListenerThread()
        {            
            Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
                while (true)
                {
                    TcpClient client = null;
                    NetworkStream netstream = null;
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        AddInfo("Kết nối với Client.");
                        ThreadPool.QueueUserWorkItem(ThreadProc, client);
                       // netstream.Close();
                       // client.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thdListener = new Thread(new ThreadStart(ListenerThread));
            portN = int.Parse(txtPort.Text);
            thdListener.Start();
            thdListener.IsBackground=true;
            AddInfo("Server đã khởi động");

        }
    }
}
