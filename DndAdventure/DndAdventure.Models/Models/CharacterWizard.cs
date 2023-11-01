using DndAdventure.Models.Constants;

namespace DndAdventure.Models.Models
{
    public class CharacterWizard
    {
        public CharacterWizardStepEnum Step { get; set; } = CharacterWizardStepEnum.CharacterDescriprion;
        
        public Character Character { get; set; }

        public List<Race> Races { get; set; }

        public List<Class> Classes { get; set; }

        public List<AbilityScores> AbilityScores { get; set; }

        public List<Equipment> Equipments { get; set; }
    }
}