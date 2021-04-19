using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Muhasebe.ORM.Tables
{
    public class UsersORM : ORMBase<UsersORM>
    {
        public bool Login(string name, string password)
        {
            DataTable dt = new DataTable();
            dt = Select();
            DataRow[] nameFromDT = dt.Select("Name like '%" + name + "%'");
            DataRow[] passwordFromDT = dt.Select("Password like '%" + password + "%'");

            if (nameFromDT[0].Equals(name) && passwordFromDT[0].Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
