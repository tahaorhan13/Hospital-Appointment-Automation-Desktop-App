using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Randevu_Projesi
{
    public abstract class LogBase{
        public abstract void Log(string Name, string Surname,string Message);
    }
    public class Logger : LogBase
    {
        private String CurrentDirectory { get; set; }
        private String FileName { get; set; }
        private String FilePath { get; set; }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        }

        public override void Log(string Name, string Surname,string Message)
        {
            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("{0} {1} {2}",Name,Surname,Message);
                w.WriteLine("------------------------------------");
            }
        }



    }
}
