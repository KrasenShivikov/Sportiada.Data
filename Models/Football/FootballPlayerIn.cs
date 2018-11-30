namespace Sportiada.Data.Models.Football
{
    public class FootballPlayerIn
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int Minute { get; set; }

        public bool FirstHalf { get; set; }

        public int SubstituteId { get; set; }

        public string InIcon { get; set; }

        public FootballSubstitute Substitute { get; set; }
    }
}
