using Entities;
using Promotion.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.BLL
{
    public class PotentialCustomerService : BaseService<PotentialCustomer>
    {
        PromotionCore db;
        public PotentialCustomerService()
        {
            db = new PromotionCore();
        }
        public int NewRegistration(PotentialCustomer data)
        {
            cmd = new SqlCommand("insert into PotentialCustomer values (@TCKimlikNo,@Name,@Surname,@BirthDay,@Gender,@Job,@EmailAddress,@EmailConfirmation,@PhoneNumber,@PhoneConfirmation,@CreationDate,@CreatorStore)");

            #region parameters.add 
            cmd.Parameters.Add("@TCKimlikNo", SqlDbType.NVarChar).Value = data.TCKimlikNo;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = data.Name;
            cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = data.Surname;
            cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = data.BirthDay;
            cmd.Parameters.Add("@Gender", SqlDbType.Int).Value = data.Gender;
            cmd.Parameters.Add("@Job", SqlDbType.NVarChar).Value = data.Job;
            cmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = data.EmailAddress;
            cmd.Parameters.Add("@EmailConfirmation", SqlDbType.Bit).Value = data.EmailConfirmation;
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = data.PhoneNumber;
            cmd.Parameters.Add("@PhoneConfirmation", SqlDbType.Bit).Value = data.PhoneConfirmation;
            cmd.Parameters.Add("@CreationDate", SqlDbType.DateTime).Value = data.CreationDate;
            cmd.Parameters.Add("@CreatorStore", SqlDbType.Int).Value = data.CreatorStore;
            #endregion

            Result = db.InsertUpdateDelete(cmd);
            return Result;
        }
        public int InquireTC(string TCKimlikNo)
        {
            cmd = new SqlCommand("Select ID from PotentialCustomer where TCKimlikNo = @TCKimlikNo");

            cmd.Parameters.Add("@TCKimlikNo",SqlDbType.NVarChar).Value = TCKimlikNo;
            obj = db.GetColumn(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
