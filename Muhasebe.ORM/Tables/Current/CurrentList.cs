using System;

namespace Muhasebe.ORM.Tables.Current
{
    public class CurrentList : ORMBase<Entity.Current>
    {
        public bool SearchFilter(string Type, string searchValue)
        {
            bool statement = false;
            switch (Type)
            {
                case "Current Code": // Sql table column name calls "Code"
                    break;
                case "Group Name": // Sql table column name calls "Title"
                    break;
                case "Personal ID": // Sql table column name calls "PersonalID"
                    break;
                case "City": // Sql table column name calls "City"
                    break;
                case "District": // Sql table column name calls "District"
                    break;
                case "Date":
                    break;
                default:
                    return false;
            }
            return statement;
        }
        private void SearchCurrentCode()
        {

        }
    }
}
