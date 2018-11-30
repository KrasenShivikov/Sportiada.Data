namespace Sportiada.Data.Models.AlpineSki
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Skier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Club { get; set; }

        public string Gender { get; set; }

        public string LargePicturePath { get; set; }

        public string SmallPicturePath { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<ResultAlpineSki> ResultsAlpineSki { get; set; } = new List<ResultAlpineSki>();
    }
}
