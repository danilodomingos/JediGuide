using JediGuide.Models.Entities.Base;
using JediGuide.Models.Enuns;

namespace JediGuide.Models.Entities
{
    public class Planet : BaseEntity
    {
        public string Name { get; set; }
        public Wheater? Wheater { get; set; }
        public Terrain? Terrain { get; set; }
    }
}