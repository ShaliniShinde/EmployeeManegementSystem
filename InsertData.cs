using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace emp_manegement
{
     class InsertData
    {
        public static void insertdata()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG2VGUJ\\SQLEXPRESS;Initial Catalog=Db;Integrated Security=True");


            con.Open();
            Console.WriteLine("please enter your id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("please enter your position");
            string pos = Console.ReadLine();

            Console.WriteLine("please enter your salary");
            int sal = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your address");
            string address = Console.ReadLine();


            string sql = "insert into Employee(Emp_id,Name,position,salary,Address) values (@id,@nm,@po,@sa,@ad)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@po", pos);
            cmd.Parameters.AddWithValue("@sa", sal); ;
            cmd.Parameters.AddWithValue("@ad", address);

            int status = cmd.ExecuteNonQuery();

            if (status != 0)
            {
                Console.WriteLine("data inserted successfully");
            }
            else
            {
                Console.WriteLine("data can not inserted successfully");
            }

        }
    }
}
