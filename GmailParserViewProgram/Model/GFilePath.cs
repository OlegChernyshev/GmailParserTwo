using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailParserViewProgram.Model
{
    [Serializable]
    public class GFilePath
    {
        static private List<GFilePath> files = new List<GFilePath>();

        static public List<GFilePath> GetFiles() { return files; }

        readonly public string filename;
        readonly public string path;

        [NonSerialized]
        static private string pathFileSave = "rules.in";
    }
}
