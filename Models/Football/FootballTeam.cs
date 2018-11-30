namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FootballTeam
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string History { get; set; }

        public string Logo { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public List<FootballStadium> Stadiums { get; set; } = new List<FootballStadium>();

        public List<FootballSide> Sides { get; set; } = new List<FootballSide>();

    }
}
