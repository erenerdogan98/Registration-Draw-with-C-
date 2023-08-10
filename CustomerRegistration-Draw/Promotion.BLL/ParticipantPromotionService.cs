using Entities;
using Promotion.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.BLL
{
    public class ParticipantPromotionService : BaseService<ParticipantPromotion>
    {
        PromotionCore db;
        public ParticipantPromotionService()
        {
            db = new PromotionCore();
        }
        public int NewReg(ParticipantPromotion data)
        {
            cmd = new System.Data.SqlClient.SqlCommand("insert into ParticipantPromotion values (@PotentialCustomerID,@PromotionProductID,@CreationDate,@StoreID)");

            cmd.Parameters.Add("@PotentialCustomerID", System.Data.SqlDbType.Int).Value = data.PotentialCustomerID;
            cmd.Parameters.Add("@PromotionProductID", System.Data.SqlDbType.Int).Value = data.PromotionProductID;
            cmd.Parameters.Add("@CreationDate", System.Data.SqlDbType.DateTime).Value = data.CreationDate;
            cmd.Parameters.Add("@StoreID", System.Data.SqlDbType.Int).Value = data.StoreID;

            return db.InsertUpdateDelete(cmd);
        }
    }
}
