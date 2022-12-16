namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FootballPlayer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfileName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string BirthPlace { get; set; }

        public string Foot { get; set; }

        public int Height { get; set; }

        public List<FootballPlayerTransfers> Transfers { get; set; } = new List<FootballPlayerTransfers>();

        public List<FootballSquadPlayer> Squads { get; set; } = new List<FootballSquadPlayer>();

        public List<FootballPlayerCountry> Countries { get; set; } = new List<FootballPlayerCountry>();

        public List<FootballLineUp> LineUps { get; set; } = new List<FootballLineUp>();

        public List<FootballPlayerIn> PlayerIns { get; set; } = new List<FootballPlayerIn>();

        public List<FootballPlayerOut> PlayerOuts { get; set; } = new List<FootballPlayerOut>();

        public List<FootballGoal> Goals { get; set; } = new List<FootballGoal>();

        public List<FootballReserve> Reserves { get; set; } = new List<FootballReserve>();

        public List<FootballGoalAssistance> GoalAssistances { get; set; } = new List<FootballGoalAssistance>();

        public List<FootballCard> Cards { get; set; } = new List<FootballCard>();

        public List<FootballSideline> Sidelines { get; set; } = new List<FootballSideline>();

    }
}
