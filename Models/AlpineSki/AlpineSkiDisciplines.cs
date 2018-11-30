namespace Sportiada.Data.Models.AlpineSki
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AlpineSkiDisciplines
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<CompetitionAlpineSki> Competitions { get; set; } = new List<CompetitionAlpineSki>();
    }
}
