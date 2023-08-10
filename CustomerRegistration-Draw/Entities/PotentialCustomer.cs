using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PotentialCustomer
    {
        public int ID { get; set; }
        public string TCKimlikNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public int Gender { get; set; }
        public string Job { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailConfirmation { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneConfirmation { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorStore { get; set; }
    }
}
