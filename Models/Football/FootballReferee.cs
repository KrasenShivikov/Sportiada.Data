namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;

    public class FootballReferee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public DateTime BirthDate { get; set; }

        public List<FootballGameReferee> GameReferees { get; set; } = new List<FootballGameReferee>();
    }
}
