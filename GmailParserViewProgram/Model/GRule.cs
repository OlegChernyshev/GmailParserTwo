using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

using GmailParserViewProgram.Act;

namespace GmailParserViewProgram.Model
{
    [Serializable]
    public class GRule : Base.BListView<GRule>
    {
        static public List<GRule> grules = new List<GRule>();

        static public void SetGrules(GRule[] value)
        {
            grules.AddRange(value);
        }

        readonly public string tag;
        readonly public string path;
        readonly public string mode;
        readonly public string type;

        [NonSerialized]
        public const string pathfile = "rules.in";

        public Predicate<GRule> Predicate(string value)
        {
            return item => item.tag == value;
        }

        public GRule()
        {
            Set(ref grules);
        }

        public GRule(string tag, string path , string mode , string type)
        {
            this.tag = tag;
            this.path = path;
            this.mode = mode;
            this.type = type;
            change = true;
        }
    }
}