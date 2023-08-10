using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Gender
    {
        public int ID;
        public  string Defination { get; set; }

        public override string ToString()
        {
            return Defination;
        }
    }
}
