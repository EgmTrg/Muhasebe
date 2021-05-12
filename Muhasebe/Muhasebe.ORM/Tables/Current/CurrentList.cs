using System;
    
namespace Muhasebe.ORM.Tables.Current
{
    public class CurrentList : ORMBase<Entity.Current>
    {
        public bool SearchFilter(string Type)
        {
            return Type == "Empty" ? true : false;  
        }
    }
}
