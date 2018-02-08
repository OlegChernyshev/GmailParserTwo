using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailParserViewProgram.Act
{
    public class AutoRun
    {
        private const string name = "MailTrigger";
        static public void Enabled ()
        {
            var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
            key.SetValue(name, Application.ExecutablePath);
        }

        static public void Disabled ()
        {
            var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
            key.DeleteValue(name);
        }

        static public bool IsEnabled ()
        {
            var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
            if (key.GetValue(name) != null) return true;
            return false;
        }
    }
}
