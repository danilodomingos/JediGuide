using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JediGuide.SWAPI.Client.Models
{
    public class Film
    {
        [JsonProperty("episode_id")]
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }

        public List<string> Planets { get; set; }

        
    }
}