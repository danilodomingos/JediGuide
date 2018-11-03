using System;
using JediGuide.Core.Entities.Base;

namespace JediGuide.Core.Entities
{
    public class Planet : BaseEntity
    {
        public string Name { get; set; }
        public string Wheater { get; set; }
        public string Terrain { get; set; }
        public int MoviesShowUp { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(this.Name)
                && !string.IsNullOrEmpty(this.Wheater)
                && !string.IsNullOrEmpty(this.Terrain);
        }
    }
}