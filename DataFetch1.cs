using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_manegement
{
    internal class DataFetch1
    {
        public static void datafetch()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG2VGUJ\\SQLEXPRESS;Initial Catalog=Db;Integrated Security=True");

            con.Open();

            string sql = "select * from Employee";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("Emp_id"));
                string name = reader.GetString(1);
                string position = reader.GetString(2);
                string salary = reader.GetString(3);
                string address = reader.GetString(4);

                Console.WriteLine("ID :" + id + " name :" + name + " postion :" + position + " salary :" + salary + " address :" + address);





            }
        }
    }
}

