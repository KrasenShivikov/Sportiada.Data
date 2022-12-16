namespace Sportiada.Data.Models.Football
{
    public class FootballPlayerOut
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int SubstituteId { get; set; }

        public string OutIcon { get; set; }

        public FootballSubstitute Substitute { get; set; }
    }
}
