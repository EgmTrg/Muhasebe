using System;
using System.Data;
using Muhasebe.Entity;

namespace Muhasebe.ORM.Tables
{
    public class User : ORMBase<Entity.User>
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
                        if (remember)
                        {
                            Entity.User currentUser = CreateUser(rows[i], true);
                            Remember(currentUser,rows);
                        }
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public bool Register(string name, string password)
        {
            try
            {
                Entity.User user = new Entity.User();
                user.Name = name;
                user.Password = password;
                user.isAdmin = false;
                user.Remember = false;
                return Insert(user);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Remember(Entity.User currentUser,DataRow[] rows)
        {
            try // It is Checking other user's Remember features.
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    if (rows[i].ItemArray[4].Equals(true))
                    {
                        Entity.User rememberActiveUser = CreateUser(rows[i], false); // If find checked remember feature, pulls data and create an user object
                        Update(rememberActiveUser); // Turning off the remember feature of the user.
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
            Update(currentUser);
        }

        private Entity.User CreateUser(DataRow rows,bool remember)
        {
            Entity.User createdUser = new Entity.User();
            createdUser.UserID = Convert.ToInt32(rows.ItemArray[0]);
            createdUser.Name = rows.ItemArray[1].ToString();
            createdUser.Password = rows.ItemArray[2].ToString();
            createdUser.isAdmin = Convert.ToBoolean(rows.ItemArray[3]);
            createdUser.Remember = remember;
            return createdUser;
        }
    }
}
