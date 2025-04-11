using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tempApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetIPHostEntry();
        }

        private  static void GetIPHostEntry()
        {
            IPHostEntry iphe1, iphe2, iphe3;
            IPAddress ipadd = IPAddress.Parse("142.250.186.206");

            iphe1 = Dns.GetHostEntry("www.google.com");
            iphe2 = Dns.GetHostEntry("mail.google.com");
            iphe3 = Dns.GetHostEntry(ipadd);

            Console.WriteLine(iphe1.HostName);
            Console.WriteLine(iphe2.HostName);
            Console.WriteLine(iphe3.HostName);
        }


        private static void TaoEndPoint()
        {
            IPAddress IPAdd = IPAddress.Parse("127.0.0.1");
            //Truyền vào cho hàm khởi tạo endPoint
            IPEndPoint Ipep = new IPEndPoint(IPAdd, 8080);
        }

        private static void TaoEndPointVoiTenMay()
        {
            IPAddress iPAdd = new IPAddress(0);
            iPAdd = Dns.GetHostAddresses("LocalHost")[0];

        }

        private static void ShowIPs()
        {
            //Lấy tất cả địa chie IP của máy
            IPAddress[] a = Dns.GetHostAddresses("DESKTOP-7DKO214");
            foreach (IPAddress ip in a)
            {
                Console.WriteLine(ip.ToString());
            }
        }

      

    }
}
