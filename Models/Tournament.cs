namespace Sportiada.Data.Models
{
    using System.Collections.Generic;
    using AlpineSki;
    using System.ComponentModel.DataAnnotations;

    public class Tournament
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; }
    }
}
