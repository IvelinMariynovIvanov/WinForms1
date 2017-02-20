using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = "Server = IVELIN-PC; Database = Softuni; Trusted_Connection = True";
            SqlConnection conection = new SqlConnection(connectionstring);
            conection.Open();

            using (conection)
            {
                string selectCommandString = "Select * from Employees";
                SqlCommand command = new SqlCommand(selectCommandString, conection);
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
