using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class User
    {
        public List<Food> foods { get; set; }
        public double yekun_mebleg { get; set; }
        public double odenilmis_mebleg { get; set; }
        public double qaliq_mebleg { get; set; }
        public User()
        {
            foods = new List<Food>();
        }
    }
}
