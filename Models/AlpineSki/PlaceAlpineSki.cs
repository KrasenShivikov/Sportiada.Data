namespace Sportiada.Data.Models.AlpineSki
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PlaceAlpineSki
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; } = new List<CompetitionAlpineSki>();
    }
}
