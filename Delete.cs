using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_manegement
{
    internal class Delete
    {
        public static void deletedata()
        {
            // Define the connection string (modify as per your database configuration)
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG2VGUJ\\SQLEXPRESS;Initial Catalog=Db;Integrated Security=True");

            try
            {
                // Open the connection
                con.Open();

                // Get the ID of the employee to delete
                Console.WriteLine("Please enter the ID of the employee to delete:");
                int id = int.Parse(Console.ReadLine());

                // Define the SQL query to delete the record
                string sql = "DELETE FROM Employee WHERE Emp_id = @id";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(sql, con);

                // Define the parameter and its value
                cmd.Parameters.AddWithValue("@id", id);

                // Execute the command
                int status = cmd.ExecuteNonQuery();

                // Check the result
                if (status != 0)
                {
                    Console.WriteLine("Data deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Data could not be deleted. No record found with the specified ID.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
