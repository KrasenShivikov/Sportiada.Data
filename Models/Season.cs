namespace Sportiada.Data.Models
{
    using AlpineSki;
    using Football;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;


    public class Season
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; } = new List<CompetitionAlpineSki>();

        public List<FootballSide> FootballSides { get; set; } = new List<FootballSide>();

        public List<FootballCompetition> FootballCompetitions { get; set; } = new List<FootballCompetition>();
    }
}
