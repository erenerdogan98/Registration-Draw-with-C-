using Entities;
using Promotion.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.BLL
{
    public class PromotionProductService : BaseService<PromotionProduct>
    {
        PromotionCore db;
        public PromotionProductService()
        {
            db = new PromotionCore();
        }
        public List<PromotionProduct> GetProductList()
        {
            list = new List<PromotionProduct>();
            cmd = new SqlCommand("select top 12 * from PromotionProduct where UsingStatus = 1 order by NEWID()");
            reader = db.List(cmd);

            while (reader.Read())
            {
                list.Add(new PromotionProduct()
                {
                    ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    Definition = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Explanation = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    ValidityDate = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    UsingStatus = reader.IsDBNull(4) ? false : reader.GetBoolean(4),
                });
            }
            reader.Close();
            db.SetConnection();
            return list; // list from BaseService
        }
        public PromotionProduct GetOneProduct(int ID)
        {
            data = new PromotionProduct();
            cmd = new SqlCommand("select * from PromotionProduct where ID = @ID");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
            reader = db.List(cmd);
            while (reader.Read())
            {
                data.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.Definition = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.Explanation = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.ValidityDate = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                data.UsingStatus = reader.IsDBNull(4) ? false : reader.GetBoolean(4); // we can write true instead of reader.GetBoolean(4) also
            }
            reader.Close();
            db.SetConnection();
            return data;
        }
        #region update promotion product
        public int Marktheproductused(int ID)
        {
            cmd = new SqlCommand("update PromotionProduct set UsingStatus = @UsingStatus where ID = @ID"); // dont forget where !!
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@UsingStatus", System.Data.SqlDbType.Bit).Value = false;
            // now we call insert-update-delete method and return that
            return db.InsertUpdateDelete(cmd);
        }
        #endregion
    }
}
