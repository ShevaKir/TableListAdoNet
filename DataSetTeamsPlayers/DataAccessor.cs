using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace DataSetTeamsPlayers
{
    public class DataAccessor
    {
        private SqlDataAdapter _adapterBD;
        private SqlConnection _connection;
        private DataSet _data;

        public DataAccessor(string connection, string sqlSelect)
        {
            _connection = new SqlConnection(connection);
            _adapterBD = new SqlDataAdapter(sqlSelect, _connection);
            _data = new DataSet();
            _adapterBD.Fill(_data);
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _data.Tables[0].AsEnumerable().Select(row => new Player
            {
                IdPlayer = (int)row["IdPlayer"],
                NamePlayer = (string)row["NamePlayer"],
                SurnamePlayer = (string)row["SurnamePlayer"],
                DateOfBirth = (DateTime)row["DateOfBirth"],
                IdTeam = (int)row["IdTeam"],
                IdCountry = (int)row["IdCountry"],
                PlayerNumber = (byte)row["PlayerNumber"]
            });

        }

        public IEnumerable<Team> GetTeams()
        {
            return _data.Tables[0].AsEnumerable().Select(row => new Team
            {
                IdTeam = (int)row["IdTeam"],
                NameTeam = (string)row["NameTeam"],
                Stadion = (string)row["Stadion"],
                IdLocation = (int)row["IdLocation"]
            });
        }

        public DataTable Table { get => _data.Tables[0];}

        public IEnumerable<Player> SelectPlayersForTeam(int idTeam)
        {
            var players = GetPlayers();
            return players.Where(player => player.IdTeam == idTeam);
        }
    }
}
