namespace Sportiada.Data.Models
{
    using AlpineSki;
    using Football;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CompetitionType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; } = new List<CompetitionAlpineSki>();

        public List<FootballCompetition> FootballCompetitions { get; set; } = new List<FootballCompetition>();
    }
}
