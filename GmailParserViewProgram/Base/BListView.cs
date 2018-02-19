using GmailParserViewProgram.Act;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GmailParserViewProgram.Base
{
    [Serializable]
    public class BListView<T>
    {
        [NonSerialized]
        private List<T> list = null;

        public List<T> Get() { return list; }

        [NonSerialized]
        static public bool change = false;
        static public bool IsChange()
        {
            return change;
        }

        static public void SetChange(bool value)
        {
            change = value;
        }

        public void Set (ref List<T> list)
        {
            this.list = list;
        }

        public void Reset()
        {
            list.Clear();
        }

        public void DeleteItem(Predicate<T> predicate)
        {
            T a = list.Find(predicate);//item => item.tag == value
            list.Remove(a);
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public void AddRange(T[] value)
        {
            list.AddRange(value);
        }
    }
}