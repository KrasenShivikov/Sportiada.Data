namespace Sportiada.Data.Models
{
    using Football;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<FootballTeam> FootballTeams { get; set; } = new List<FootballTeam>();
    }
}
