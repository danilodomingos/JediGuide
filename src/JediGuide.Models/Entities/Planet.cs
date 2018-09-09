using JediGuide.Models.Entities.Base;

namespace JediGuide.Models.Entities
{
    public class Planet : BaseEntity
    {
        public string Name { get; set; }
        public string Wheater { get; set; }
        public string Terrain { get; set; }
    }
}