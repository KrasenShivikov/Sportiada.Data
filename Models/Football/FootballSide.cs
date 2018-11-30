namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FootballSide
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }

        public int TeamId { get; set; }

        public FootballTeam Team { get; set; }

        public List<FootballSidePlayer> Players { get; set; } = new List<FootballSidePlayer>();

        public List<FootballSideCoach> Coaches { get; set; } = new List<FootballSideCoach>();

        public List<FootballGameStatistic> GameStatistics { get; set; } = new List<FootballGameStatistic>();

    }
}
