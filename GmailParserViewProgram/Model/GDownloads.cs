using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailParserViewProgram.Model
{
    [Serializable]
    public class GDownloads : Base.BListView<GDownloads>
    {
        static public List<GDownloads> gdownloads = new List<GDownloads>();

        static public void SetDownloads(GDownloads[] value)
        {
            gdownloads.AddRange(value);
        }

        readonly public string filename;
        readonly public string path;

        [NonSerialized]
        public const string pathfile = "downloads.in";
        [NonSerialized]
        static private bool change = false;
        static public bool IsChange()
        {
            return change;
        }

        static public void SetChange(bool value)
        {
            change = value;
        }

        public Predicate<GDownloads> Predicate(string value)
        {
            return item => item.path == value;
        }

        public GDownloads()
        {
            Set(ref gdownloads);
        }

        public GDownloads(string filename, string path)
        {
            this.filename = filename;
            this.path = path;
            change = true;
        }
    }
}
