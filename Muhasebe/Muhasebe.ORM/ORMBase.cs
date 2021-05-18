using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Muhasebe.ORM
{
    public class ORMBase<Table> : IORM<Table> where Table : class
    {
        public Type myVariableType { get { return typeof(Table); } }
        public DataTable SelectDB()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Connection;
            cmd.CommandText = $"{myVariableType.Name}_Select";
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            return dt;
        }
        public bool Insert(Table t)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"{myVariableType.Name}_Insert";
            cmd.Connection = Tools.Connection;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] props = myVariableType.GetProperties();
            foreach (var prop in props)
                cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(t));
            return Tools.ExecuteQuerry(cmd);
        }
        public bool Update(Table t)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"{myVariableType.Name}_Update";
            cmd.Connection = Tools.Connection;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] props = myVariableType.GetProperties();
            foreach (PropertyInfo prop in props)
                cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(t));
            return Tools.ExecuteQuerry(cmd);
        }
        public bool Delete(int id)
        {
            Table table = Activator.CreateInstance<Table>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"{myVariableType.Name}_Delete";
            cmd.Connection = Tools.Connection;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo prop = myVariableType.GetProperty("PrimaryKey");
            cmd.Parameters.AddWithValue($"@{prop.GetValue(table)}", id);
            return Tools.ExecuteQuerry(cmd);
        }

    }
}
