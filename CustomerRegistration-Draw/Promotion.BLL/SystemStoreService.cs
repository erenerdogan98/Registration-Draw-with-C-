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
    public class SystemStoreService : BaseService<SystemStore> // we add reference entities and .core and we inherited BaseService
    {
        PromotionCore db; // we write here in class level and we sample this by new in constructor method
        public SystemStoreService()
        {
            db = new PromotionCore();
        }
        public int StoreUserControl(string username, string password)
        {
            cmd = new SqlCommand("select ID from SystemStore where username = @UserName and password = @Password",con);

            cmd.Parameters.Add("@UserName",SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@Password",SqlDbType.NVarChar).Value=password;

            obj = db.GetColumn(cmd);
            return obj == null ? 0 : (int)obj;  
        }
    }
}
