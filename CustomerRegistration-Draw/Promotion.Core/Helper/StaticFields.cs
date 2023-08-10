using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Core.Helper
{
    public static class StaticFields
    {
        public static int StoreID { get; set; }

        // for choosen gender
        public static List<Gender> Genders()
        {
            List<Gender> genderlist = new List<Gender>();
            genderlist.Add(new Gender() { ID = 1, Defination = "Male" });
            genderlist.Add(new Gender() { ID = 2, Defination = "Female" });
            return genderlist;
        }   
    }
}
