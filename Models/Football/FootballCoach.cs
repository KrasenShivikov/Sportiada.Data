namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;

    public class FootballCoach
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public List<FootballSideCoach> Sides { get; set; } = new List<FootballSideCoach>();
    }
}
