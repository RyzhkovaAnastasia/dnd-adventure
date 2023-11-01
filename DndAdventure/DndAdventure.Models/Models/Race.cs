namespace DndAdventure.Models.Models
{
    public class Race
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Trait> Traits { get; set; }

        public int Speed { get; set; }

        public List<Language> Languages { get; set; }
    }
}