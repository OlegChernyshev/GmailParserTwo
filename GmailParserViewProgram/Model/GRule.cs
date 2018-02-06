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
    public class GRule
    {

        static private List<GRule> grules = new List<GRule>();

        static public List<GRule> GetGrules() { return grules; }

        [NonSerialized]
        static private string pathFileSave = "rules.in";

        [NonSerialized]
        readonly public string tag;
        [NonSerialized]
        readonly public string path;

        public GRule (string tag , string path)
        {
            this.tag = tag;
            this.path = path;
            grules.Add(this);
        }

        static public void Save ()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = FileParser.CreateOrOpen(pathFileSave);
            binaryFormatter.Serialize( fs , grules );
            fs.Close();
        }

        static public void Read ()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = FileParser.CreateOrOpen(pathFileSave);
            grules = (List<GRule>)binaryFormatter.Deserialize(FileParser.CreateOrOpen(pathFileSave));
            fs.Close();
        }

        static public void Reset ()
        {
            grules.Clear();
            FileParser.Delete(pathFileSave);
        }

        static public void DeleteItem ( string value )
        {
            GRule a = grules.Find(item => item.tag == value);
            grules.Remove(a);
        }
    }
}