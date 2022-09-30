using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Agent
    {
        private string user;
        private string password;
        private string name;

        public Agent(string user, string password, string name)
        {
            this.user = user;
            this.password = password;
            this.name = name;
        }

        private string User { get => user; set => user = value; }
        private string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }

        public bool LoginCheck(string user, string password)
        {
            if(user == this.user && password == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
