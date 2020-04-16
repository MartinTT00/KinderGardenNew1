using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructer
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Kid> Kids { get; set; }
    }
}
