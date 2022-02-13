using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataSetTeamsPlayers;

namespace _20220202_TableList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 200;

            DataAccessor teams = new DataAccessor(StringConnectionToDataBase.GetStringConnect(), "Select * from Teams");
            DataAccessor players = new DataAccessor(StringConnectionToDataBase.GetStringConnect(), "Select * from Players");

            var dataPlayers = teams.GetTeams();
            UI.ViewTable(dataPlayers);
            Console.WriteLine();

            int id = int.Parse(Console.ReadLine());
            var select = players.SelectPlayersForTeam(id);
            Console.WriteLine();
            UI.ViewTable(select);

            Console.ReadLine();
        }
    }
}
