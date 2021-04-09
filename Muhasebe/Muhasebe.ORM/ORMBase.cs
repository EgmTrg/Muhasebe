using System.Data;

namespace Muhasebe.ORM
{
    public class ORMBase<Table> : IORM<Table> where Table : class
    {
        public DataTable Select()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Table t)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Table t)
        {
            throw new System.NotImplementedException();
        }
                
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}
