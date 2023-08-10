using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ParticipantPromotion // for reference
    {
        public int ID { get; set; }
        public int PotentialCustomerID { get; set; }
        public int PromotionProductID { get; set; }
        public DateTime CreationDate { get; set; }
        public int StoreID { get; set; }
    }
}
