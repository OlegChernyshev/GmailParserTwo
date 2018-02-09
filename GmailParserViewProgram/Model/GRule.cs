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

        readonly public string tag;
        readonly public string path;

        [NonSerialized]
        static private string pathFileSave = "rules.in";



        public GRule(string tag, string path)
        {
            this.tag = tag;
            this.path = path;
        }

        static public void Save()
        {
            FileStream s;
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            //FileStream fs = FileParser.CreateOrOpen(pathFileSave);
            if (File.Exists(pathFileSave))
            {
                s = File.Open(pathFileSave, FileMode.Open);
            }
            else s = File.Create(pathFileSave);
            if (s != null)
            {
                s.Close();
                GRule[] mas = grules.ToArray();
                File.WriteAllBytes(pathFileSave, ObjectToByteArray(mas));
            }
            //binaryFormatter.Serialize( fs , grules );
            //fs.Close();
        }

        static public void Read()
        {
            FileStream s;
            /*
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = FileParser.CreateOrOpen(pathFileSave);
            fs.Close();
            fs = FileParser.CreateOrOpen(pathFileSave);
            if (fs.Length > 0)
                grules = (List<GRule>)binaryFormatter.Deserialize(fs);
            fs.Close();
            */
            if (File.Exists(pathFileSave))
            {
                s = File.Open(pathFileSave, FileMode.Open);
            }
            else s = File.Create(pathFileSave);
            if (s != null)
            {
                s.Close();
                byte[] bytes = File.ReadAllBytes(pathFileSave);
                if (bytes.Length > 0)
                {
                    GRule[] mas = (GRule[])ByteArrayToObject(bytes);
                    grules.AddRange(mas);
                }
                    
            }

        }

        static public void Reset()
        {
            grules.Clear();
            //FileParser.Delete(pathFileSave);
        }

        static public void DeleteItem(string value)
        {
            GRule a = grules.Find(item => item.tag == value);
            grules.Remove(a);
        }

        static public void Add(string tag, string path)
        {
            grules.Add(new GRule(tag, path));
        }

        static public void Add(GRule gRule)
        {
            grules.Add(gRule);
        }

        // Convert an object to a byte array
        static private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        // Convert a byte array to an Object
        static private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);

            return obj;
        }
    }
}