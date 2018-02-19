using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailParserViewProgram.Act
{
    public class DataLoginAct
    {
        static private Int32 number = 16769023;

        static private FileStream fileStream = null;

        static private byte[] ConverterStringToBytes(string str)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str);
            List<Int32> int32s = new List<Int32>();
            foreach (byte item in bytes)
            {
                Int32 int32 = Convert.ToInt32(item);
                int32 *= number;
                int32s.Add(int32);
            }

            List<byte> result = new List<byte>();

            foreach (Int32 item in int32s)
            {
                byte[] b = BitConverter.GetBytes(item);
                result.AddRange(b);
            }

            return result.ToArray();
        }

        static private string ConverterBytesToStrint(byte[] bytes)
        {
            string str = String.Empty;
            Int32 int32 = 0;
            for (int i = 0; i < bytes.Length;)
            {
                byte[] b = new byte[4];
                for (; i < 4; i++)
                {
                    b[0] = bytes[i];
                    b[1] = bytes[i+1];
                    b[2] = bytes[i+2];
                    b[3] = bytes[i+3];
                    int32 = BitConverter.ToInt32(b, 0);
                    int32 /= number;
                    str += Encoding.ASCII.GetString(b);
                }
            }
            return str;
        }

        static public void Read()
        {
            byte[] mas = ConverterStringToBytes("chernyshev360@gmail.com");

        }

        static public void Write()
        {

        }
    }
}
