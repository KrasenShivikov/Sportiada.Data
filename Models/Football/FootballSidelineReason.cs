namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballSidelineReason
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public List<FootballSideline> Sidelines { get; set; } = new List<FootballSideline>();
    }
}
