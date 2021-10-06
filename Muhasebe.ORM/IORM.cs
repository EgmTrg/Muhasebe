using System.Data;

namespace Muhasebe.ORM
{
    public interface IORM<Table> where Table : class
    {
        DataTable SelectDB();
        bool Insert(Table t);
        bool Update(Table t);
        bool Delete(int id);
    }
}
