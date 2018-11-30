namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FootballTournament
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<FootballCompetition> Competitions { get; set; } = new List<FootballCompetition>();
    }
}
