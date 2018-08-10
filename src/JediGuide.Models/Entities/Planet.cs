using JediGuide.Models.Enuns;

namespace JediGuide.Models.Entities
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Wheater? Wheater { get; set; }
        public Terrain? Terrain { get; set; }
    }
}