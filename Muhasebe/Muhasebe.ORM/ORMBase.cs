using System;
using System.Data;
using System.Data.SqlClient;

namespace Muhasebe.ORM
{
    public class ORMBase<Table> : IORM<Table> where Table : class
    {
        public Type myVariableType { get { return typeof(Table); } }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Connection;
            cmd.CommandText = $"Select_{myVariableType.Name}";
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            return dt;
        }

        public bool Insert(Table t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Table t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
