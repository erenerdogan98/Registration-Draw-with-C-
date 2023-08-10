using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SystemStore
    {
        public int ID { get; set; }
        public string Definition { get; set; }
        public string Address { get; set; }
        public string AuthorizedPerson { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
