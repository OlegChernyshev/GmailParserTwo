using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailParserViewProgram.Model
{
    
    public class DataLoginModel
    {
        readonly static public string fileName = "dlog.in";

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DataLoginModel (string email , string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
