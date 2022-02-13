using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetTeamsPlayers
{
    public class Player
    {
        public int IdPlayer { get; set; }

        public string NamePlayer { get; set; }

        public string SurnamePlayer { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int IdCountry { get; set; }

        public int IdTeam { get; set; }

        public byte PlayerNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                    IdPlayer, NamePlayer, SurnamePlayer, DateOfBirth, IdCountry, IdTeam, PlayerNumber);
        }
    }
}
