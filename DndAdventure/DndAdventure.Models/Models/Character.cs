namespace DndAdventure.Models.Models
{
    public class Character
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Description Description { get; set; }

        public Race Race { get; set; }

        public Class Class { get; set; }

        public AbilityScores AbilityScores { get; set; }

        public Equipment Equipment { get; set; }
    }
}
