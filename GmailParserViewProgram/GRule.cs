using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GmailParserViewProgram
{
    public class GRule
    {
        readonly static public  List<GRule> grules = new List<GRule>();

        readonly public string tag;
        readonly public string path;

        public GRule (string tag , string path)
        {
            this.tag = tag;
            this.path = path;
            grules.Add(this);
        }
    }
}