using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructer
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EGN { get; set; }
        public string Sex { get; set; }

        public int PhoneNumber { get; set; }

        List<Kid> Kids { get; set; }
    }
}
