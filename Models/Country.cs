﻿namespace Sportiada.Data.Models
{
    using Models.AlpineSki;
    using Models.Football;
    using System.Collections.Generic;  
    using System.ComponentModel.DataAnnotations;
    

    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string PicturePath { get; set; }

        public List<City> Cities { get; set; } = new List<City>();

        public List<Skier> Skiers { get; set; } = new List<Skier>();

        public List<FootballPlayerCountry> FootballPlayers { get; set; } = new List<FootballPlayerCountry>();

        public List<FootballCoach> FootballCoaches { get; set; } = new List<FootballCoach>();

        public List<FootballReferee> FootballReferees { get; set; } = new List<FootballReferee>();

        public List<FootballTournament> FootballTournaments { get; set; } = new List<FootballTournament>();

        public List<PlaceAlpineSki> Places { get; set; } = new List<PlaceAlpineSki>();   
    }
}
