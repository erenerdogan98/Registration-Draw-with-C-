using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PromotionProduct
    {
        public int ID { get; set; }
        public string Definition { get; set; }
        public string Explanation { get; set; }
        public DateTime ValidityDate { get; set; }
        public bool UsingStatus { get; set; }
    }
}
