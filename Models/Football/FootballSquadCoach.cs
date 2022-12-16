namespace Sportiada.Data.Models.Football
{
    using System;

    public class FootballSquadCoach
    {

        public int SquadId { get; set; }

        public FootballSquad Squad { get; set; }

        public int CoachId { get; set; }

        public FootballCoach Coach { get; set; }

        public string Position { get; set; }

        public string SquadType { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public bool LeftInSeason { get; set; }

    }
}
