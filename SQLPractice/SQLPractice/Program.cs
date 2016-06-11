using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Director director = new Director();
            //Operator op = new InsertOperator();

            ////input Select, Insert, Update, Delete statement:
            //op.ConnectionString = Varables.ConnectionStr;
            //op.cmd.CommandText = "CREATE TABLE Persons"+
            //    "(PersonID int,LastName varchar(255),FirstName varchar(255)," + 
            //    "Address varchar(255),City varchar(255)); ";

            //director.Construct(op);
            string connectionString = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("{0}{1}",reader["column1"], reader["column2"]);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from table", conn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "table");
            DataTable dataTable = dataSet.Tables["table"];
            // read:
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach(DataColumn dataColumn in dataTable.Columns)
                {
                    Console.WriteLine(dataRow[dataColumn]);
                }
            }
            //update:

            DataRow dr = dataTable.NewRow();
            dr["id"] = 1;
            dr["name"] = "zz";
            dataTable.Rows.Add(dr);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(dataSet, "table");

            dataTable.Rows[0].Delete();


        }
    }
}
