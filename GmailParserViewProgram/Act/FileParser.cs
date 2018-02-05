using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GmailParserViewProgram.Act
{
    public class FileParser
    {
        static private FileStream lastFile = null;
        static public FileStream LastFile
        {
            get { return lastFile; }
            private set { lastFile = value; }
        }

        static public void Delete (string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        static public FileStream CreateOrOpen (string path)
        {
            if (File.Exists(path))
            {
                return lastFile = File.Open(path, FileMode.Open);
            }
            else return lastFile = File.Create(path);
        }

        
    }
}
