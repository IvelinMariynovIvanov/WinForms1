using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SimpleSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = 
                "Server = ivelin-pc; Database = Softuni; Trusted_Connection = True";
            SqlConnection currentConection = new SqlConnection(connectionString);
            currentConection.Open();

            using (currentConection)
            {
                string commandstring = "Select * from Employees";
                SqlCommand command = new SqlCommand(commandstring, currentConection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
