namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;

    public class FootballCoach
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ShortName { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public DateTime? BirthDate { get; set; }

        public string BirthPlace { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public List<FootballGameStatisticCoach> GameStatisticCoaches { get; set; } = new List<FootballGameStatisticCoach>();

        public List<FootballSquadCoach> Squads { get; set; } = new List<FootballSquadCoach>();

        public List<FootballCoachTeam> Teams { get; set; } = new List<FootballCoachTeam>();

        
    }
}
