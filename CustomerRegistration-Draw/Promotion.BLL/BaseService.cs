using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.BLL
{
    public class BaseService<T>
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int Result;
        public object obj;
        public List<T> list;
        public T data;
    }
}
