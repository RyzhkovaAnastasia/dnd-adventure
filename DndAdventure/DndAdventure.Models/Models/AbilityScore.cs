namespace DndAdventure.Models.Models
{
    public class AbilityScore
    {
        public int TotalScore { get; set; }

        public int Modifier { get; set; }

        public int BaseScore { get; set; }

        public int RacialBonus { get; set; }

        public int AbilityImprovements { get; set; }

        public int MiscBonus { get; set; }

        public int SetScore { get; set; }

        public int OtherModifier { get; set; }

        public int OverrideScore { get; set; }
    }
}
