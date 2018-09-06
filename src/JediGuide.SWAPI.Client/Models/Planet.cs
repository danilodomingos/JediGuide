using System;
using Newtonsoft.Json;

namespace JediGuide.SWAPI.Client.Models
{
    public class Planet
    {
        public string Name { get; set; }

        [JsonProperty("rotation_period")]
        public int RotationPeriod { get; set; }

        [JsonProperty("orbital_period")]
        public int OrbitalPeriod { get; set; }

        public double Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        public string SurfaceWater { get; set; }
        public double Population { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }
    }
}