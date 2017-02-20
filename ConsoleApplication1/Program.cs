using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Server=.; Database=SoftUni; Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using (connection)
            {
                string creationCommandString = "INSERT INTO JudgeFails VALUES " +
                                               "('Judge RIP', 300), " +
                                               "('Judge Reborn', 200)";
                SqlCommand createCommand = new SqlCommand(creationCommandString, connection);
                Console.WriteLine(
                createCommand.ExecuteNonQuery());
            }
        }
    }
}
