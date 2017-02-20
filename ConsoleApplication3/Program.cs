using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string conectinoString = "Server=ivelin-pc; Database=softuni;Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(conectinoString);
            connection.Open();

            using (connection)
            {
                string commandSelect = "Select * from employees";
                SqlCommand command = new SqlCommand(commandSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader[i]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
