using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server.Services
{
    public static class LogService
    {

        public static void log(String type,String inputMessage)
        {
            string now = DateTime.Now.ToString("dd_MM_yyyy");
            string filePath = @"C:\Logs\log_" + now + ".txt";
            Console.WriteLine(File.Exists(filePath));
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("["+type+" log]: "+DateTime.Now+"  :"+inputMessage);
            }

        }
    }
}
