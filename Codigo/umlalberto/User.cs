using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class User
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private int telephone;
        private string address;
        private string DNI;
        public List<Product> whislist;

        public User(string name, string surname, string email, string password, int telephone, string address, string DNI, List<Product> whislist)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.telephone = telephone;
            this.address = address;
            this.DNI = DNI;
            this.whislist = whislist;
        }
    }
}
