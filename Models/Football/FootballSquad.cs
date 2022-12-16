using System;
using System.Collections.Generic;
using System.Text;

namespace Sportiada.Data.Models.Football
{
    public class FootballSquad
    {
        public int Id { get; set; }

        public int SeasonId { get; set; }
        public Season Season { get; set; }

        public int TeamId { get; set; }

        public FootballTeam Team { get; set; }

        public List<FootballSquadPlayer> Players { get; set; } = new List<FootballSquadPlayer>();

        public List<FootballSquadCoach> Coaches { get; set; } = new List<FootballSquadCoach>();

        public List<FootballGameStatistic> GameStatistics { get; set; } = new List<FootballGameStatistic>();

    }
}
