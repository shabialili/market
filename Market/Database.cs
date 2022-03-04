using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class Database
    {
        public List<User> users { get; set; }
        public Database()
        {
            users = new List<User>();
        }
    }
}
