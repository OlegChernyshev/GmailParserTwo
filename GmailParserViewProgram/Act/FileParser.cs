using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        static public void Save(string path , object obj)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var s = FileParser.CreateOrOpen(path);
            if (s != null)
            {
                s.Close();
                File.WriteAllBytes(path, ObjectToByteArray(obj));
            }
        }

        static public object Read(string path)
        {
            var s = FileParser.CreateOrOpen(path);
            if (s != null)
            {
                s.Close();
                byte[] bytes = File.ReadAllBytes(path);
                if (bytes.Length > 0)
                    return ByteArrayToObject(bytes);
            }
            return null;
        }

        static public FileStream CreateOrOpen (string path)
        {
            if (File.Exists(path))
            {
                return lastFile = File.Open(path, FileMode.Open);
            }
            else return lastFile = File.Create(path);
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
