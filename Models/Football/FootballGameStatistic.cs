namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballGameStatistic
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public FootballGameStatisticType Type { get; set; }

        public int GameId { get; set; }

        public FootballGame Game { get; set; }

        public int SquadId { get; set; }

        public FootballSquad Squad { get; set; }

        public List<FootballGameStatisticCoach> Coaches { get; set; } = new List<FootballGameStatisticCoach>();

        public List<FootballLineUp> LineUps { get; set; } = new List<FootballLineUp>();

        public List<FootballSideline> Sidelines { get; set; } = new List<FootballSideline>();

        public List<FootballReserve> Reserves { get; set; } = new List<FootballReserve>();

        public List<FootballSubstitute> Substitutes { get; set; } = new List<FootballSubstitute>();

        public List<FootballCard> Cards { get; set; } = new List<FootballCard>();

        public List<FootballGoal> Goals { get; set; } = new List<FootballGoal>();

        public int BallPossession { get; set; }

        public int Corners { get; set; }

        public int ShotsOnTarget { get; set; }

        public int ShotsWide { get; set; }

        public int Fouls { get; set; }

        public int Offsides { get; set; }
    }
}
