using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string connectionstring =
            //       "Server = IVELIN-PC; Database = SoftUni; Trusted_Connection = True";
            Console.WriteLine("Write server name");
            string Server = Console.ReadLine();
            Console.WriteLine("Write database name");
            string Database = Console.ReadLine();
            bool TrustedConnection = true;

            try
            {
                string connectionstring =
               $"Server = {Server}; Database = {Database}; Trusted_Connection = {TrustedConnection}";
                SqlConnection currentConection = new SqlConnection(connectionstring);
                currentConection.Open();
                using (currentConection)
                {
                    string selectionCommandString = "Select * from Employees";
                    SqlCommand command = new SqlCommand(selectionCommandString, currentConection);
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

            catch (Exception)
            {

                Console.WriteLine("Wrong name of database or server name");
            }
        }
    }
}
            
            

