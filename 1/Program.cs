using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring =
                "Server = ivelin-pc; Database = MinionsDB; Trusted_Connection = True";
            SqlConnection currentConnection = new SqlConnection(connectionstring);
            currentConnection.Open();

            using (currentConnection)
            {
                string createDbMinions = "create database MinionsDB";
                SqlCommand command = new SqlCommand(createDbMinions, currentConnection);
                command.ExecuteNonQuery();
            }

            using (currentConnection)
            {
                currentConnection.Open();
                string createtableTowns =
                   "create table Towns(Id int not null primary key identity,Name nvarchar(50),Country nvarchar(50))";
                string createTableMinions =
                    "create table minions(Id int not null primary key identity,Name nvarchar(50),Age int,Town nvarchar(50),TownId int not null,constraint Fk_Minions_Towns foreign key(TownId)references towns(Id))";
                string creteTableVillains =
                    "create table Villains (Id int not null primary key identity,Name nvarchar(50),Evilnessfactor nvarchar(50),constraint checkEvilnessfactorcheck(Evilnessfactor in ('good', 'bad', 'evil', 'super evil')))";
                string creteTableminionsVillains =
                    "create table minionsVillains(MinonsId int not null,VillainsId int not null,constraint PK_minionsVillains primary key(MinonsId, VillainsId),constraint FK_minionsVillains_Minions foreign key(MinonsId)references Minions(id),constraint FK_minionsVillains_Villains foreign key(VillainsId)references Villains(Id))";

                ExecuteCommand(createtableTowns, currentConnection);
                ExecuteCommand(createTableMinions, currentConnection);
                ExecuteCommand(creteTableVillains, currentConnection);
                ExecuteCommand(creteTableminionsVillains, currentConnection);

                string insertTownsSQL = "INSERT INTO Towns (Name, Country) VALUES ('Sofia','Bulgaria'), ('Burgas','Bulgaria'), ('Varna', 'Bulgaria'), ('London','UK'),('Liverpool','UK'),('Ocean City','USA'),('Paris','France')";
                string insertMinionsSQL = "INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),('kevin',12,2),('steward',9,3), ('rob',22,3), ('michael',5,2),('pep',3,2)";
                string insertVillainsSQL = "INSERT INTO Villains (Name, EvilnessFactor) VALUES ('Gru','super evil'),('Victor','evil'),('Simon Cat','good'),('Pusheen','super good'),('Mammal','evil')";
                string insertMinionsVillainsSQL = "INSERT INTO MinionsVillains VALUES (1,2), (3,1),(1,3),(3,3),(4,1),(2,2),(1,1),(3,4), (1, 4), (1,5), (5, 1), (4,1), (3, 1)";

                ExecuteCommand(insertTownsSQL, currentConnection);
                ExecuteCommand(insertMinionsSQL, currentConnection);
                ExecuteCommand(insertVillainsSQL, currentConnection);
                ExecuteCommand(insertMinionsVillainsSQL, currentConnection);
            }
        }

        public static void ExecuteCommand(string command, SqlConnection connection)
        {
            SqlCommand com = new SqlCommand(command, connection);
            com.ExecuteNonQuery();
        }
    }
}
