using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String p = "/test/demo.txt";
            using (var fs = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte data fs.Read();
            }
        }
    }
}
