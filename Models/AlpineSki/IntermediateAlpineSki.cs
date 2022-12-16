namespace Sportiada.Data.Models.AlpineSki
{
    using System.ComponentModel.DataAnnotations;

    public class IntermediateAlpineSki
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Time { get; set; }

        [Range(1, int.MaxValue)]
        public int Place { get; set; }

        public string Difference { get; set; }

        public string Speed { get; set; }

        public int ResultAlpineSkiId { get; set; }

        public ResultAlpineSki ResultAlpineSki {get; set; }
    }
}
