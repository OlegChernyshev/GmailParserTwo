using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailParserViewProgram.Model
{
    static class СONCEPT
    {
        public struct MODE
        {
            public const string subject = "subject";
            public const string label = "label";
            public const string filename = "filename";
        }

        static public string GetFilename (string str)
        {
            return MODE.filename + ":(" + str + ")";
        }

        static public string GetSubject (string str)
        {
            return MODE.subject + ":(" + str + ")";
        }

        static public string GetLabel(string str)
        {
            return MODE.label + ":(" + str + ")";
        }

        public struct DISCRIPTION
        {
            public const string label = "label text";

            public const string subject = "(Eng)The search is based on the words in the subject \n" +
                       "line of the message.Enter a keyword (a few words) \n" +
                       "and get the message that contains it in your header. \n\n" +
                       "(Rus)Поиск происходит на основе слов в строке темы \n" +
                       "сообщения.Введите ключевое слово(несколько слов) \n" +
                       "и получите сообщее , которое его содержит в \n" +
                       "своем заголовке. \n";
        }
    }
}
