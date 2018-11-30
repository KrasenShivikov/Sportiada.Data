namespace Sportiada.Data.Models.Football
{
    public class FootballPlayerCountry
    {
        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public bool MainCountry { get; set; }
    }
}
