namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FootballPlayerType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
    }
}
