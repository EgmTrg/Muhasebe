using Muhasebe.Entity;
using System.Data;

namespace Muhasebe.ORM.Tables
{
    public class Users : ORMBase<User>
    {
        public bool Login(string name, string password, bool remember)
        {
            DataRow[] rows = SelectDB().Select();
            try
            {
                for (int i = 0; i <= rows.Length; i++)
                {
                    if (rows[i].ItemArray[4].Equals(true))
                        return true;
                    else if (rows[i].ItemArray[1].Equals(name) && rows[i].ItemArray[2].Equals(password))
                    {
                        /*if (remember)
                            Update(new User());*/
                        return true;
                    }
                }
            }
            catch (System.Exception)
            {
                return false;
            }
            return false;
        }

        public bool Register(string name, string password)
        {
            try
            {
                User user = new User();
                user.Name = name;
                user.Password = password;
                user.isAdmin = false;
                user.Remember = false;
                Insert(user);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
