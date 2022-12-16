namespace Sportiada.Data.Models
{
    using AlpineSki;
    using Football;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;


    public class Season
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; } = new List<CompetitionAlpineSki>();

        public List<FootballCompetition> FootballCompetitions { get; set; } = new List<FootballCompetition>();

        public List<FootballSquad> FootballSquads { get; set; } = new List<FootballSquad>();
    }
}
