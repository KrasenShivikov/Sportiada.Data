namespace Sportiada.Data.Models.Football
{
    using System;

    public class FootballTeamCoach
    {

        public int TeamId { get; set; }

        public FootballTeam Team { get; set; }

        public int CoachId { get; set; }

        public FootballCoach Coach { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? UntilDate { get; set; }

        public string Description { get; set; }

    }
}
