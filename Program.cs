using static System.Runtime.InteropServices.JavaScript.JSType;

namespace emp_manegement
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("Hello, World!");

           InsertData.insertdata();
           DataFetch1.datafetch();
           Update.update();
           Delete.deletedata();
        }
    }
}



