using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_manegement
{
    internal class Update
    {

        public static void update()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG2VGUJ\\SQLEXPRESS;Initial Catalog=Db;Integrated Security=True");
            con.Open();

            String sql = "update Employee set Name=@nm,position=@po,salary=@sa,address=@ad where Emp_id=@id";

            Console.WriteLine("Please enter your id which you want to update");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your name which you want to update");
            String name = Console.ReadLine();

            Console.WriteLine("Please enter your position which you want to update");
            String pos = Console.ReadLine();

            Console.WriteLine("Please enter your salary which you want to update");
            String sal = Console.ReadLine();

            Console.WriteLine("Please enter your address which you want to update");
            String address = Console.ReadLine();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@po", pos);
            cmd.Parameters.AddWithValue("@sa", sal);
            cmd.Parameters.AddWithValue("@ad", address);
            cmd.Parameters.AddWithValue("@id", id);


            int status = cmd.ExecuteNonQuery();

            if (status != 0)
            {
                Console.WriteLine("Data updated successfully");
            }
            else
            {
                Console.WriteLine("data not inserted successfully");
            }

        }

    }
}
