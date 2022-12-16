namespace Sportiada.Data.Models.AlpineSki
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ResultAlpineSki
    {
        public int Id { get; set; }

        public int SkierId { get; set; }

        public Skier Skier { get; set; }

        public string Stage { get; set; }

        public int CompetitionAlpineSkiId { get; set; }

        public CompetitionAlpineSki CompetitionsAlpineSki { get; set; }

        public string TimeFirstManch { get; set; }

        public string TimeSecondManch { get; set; }

        public string FinalTime { get; set; }

        public string Difference { get; set; }

        public string Metters { get; set; }

        [Range(1, int.MaxValue)]
        public int Place { get; set; }

        public int Bib { get; set; }

        public int StartOrder { get; set; }

        public List<IntermediateAlpineSki> IntermediatesAlpineSki { get; set; } = new List<IntermediateAlpineSki>();

    }
}
