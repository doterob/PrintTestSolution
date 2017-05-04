using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTestWpf
{
    class ShellPrintHelper : PrintHelper
    {
        public override void Print(string printer, string file)
        {
            Process process = new Process();

            process.StartInfo.FileName = file;
            process.StartInfo.Verb = "printto";
            process.StartInfo.Arguments = "\"" + printer + "\"";
            process.Start();

            process.WaitForInputIdle();
            process.Kill();
        }
    }
}
