using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLPractice
{
    public abstract class Operator
    {
        public string ConnectionString { get; set; }
        public string CommandText { get; set; }
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection sqlConnection;
        public SqlDataReader reader;

        public void Connect()
        {
            if (ConnectionString == null || ConnectionString == "")
                return;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.Open();
                cmd.Connection = sqlConnection;
            }
            catch { }            
        }

        public abstract void CmdExecute();

        public void Dispose()
        {
            sqlConnection.Close();
            cmd.Dispose();
            reader.Close();
        }
    }

    public class SelectOperator : Operator
    {
        public override void CmdExecute()
        {
            
            reader = cmd.ExecuteReader();
        }
    }

    public class InsertOperator : Operator
    {
        public override void CmdExecute()
        {
            cmd.ExecuteNonQuery();

        }
    }

    public class UpdateOperator : Operator
    {
        public override void CmdExecute()
        {
            cmd.ExecuteNonQuery();
        }
    }

    public class DeleteOperator : Operator
    {
        public override void CmdExecute()
        {
            cmd.ExecuteNonQuery();
        }
    }

    public class Director
    {
        public void Construct(Operator o)
        {
            o.Connect();
            o.CmdExecute();
            o.Dispose();
        }
    }
}
