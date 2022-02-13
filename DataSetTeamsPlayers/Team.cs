using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetTeamsPlayers
{
    public class Team
    {
        public int IdTeam { get; set; }

        public string NameTeam { get; set; }

        public string Stadion { get; set; }

        public int IdLocation { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0} Team: {1},\t\t\t Stadion: {2},\t\t\t IdLocation: {3}",
                    IdTeam, NameTeam, Stadion, IdLocation);
        }
    }
}
