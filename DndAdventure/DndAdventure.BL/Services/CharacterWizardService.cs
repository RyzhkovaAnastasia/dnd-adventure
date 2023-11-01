using DndAdventure.BL.Interfaces;
using DndAdventure.Models.Models;

namespace DndAdventure.BL.Services
{
    public class CharacterWizardService : ICharacterWizardService
    {
        private readonly IRaceService _raceService;
        private readonly ICharacterService _characterService;
        private readonly IClassService _classService;

        public CharacterWizardService(
            IRaceService raceService, 
            ICharacterService characterService,
            IClassService classService)
        {
            _raceService = raceService;
            _characterService = characterService;
            _classService = classService;
        }

        public CharacterWizard NewCharacterWizard()
        {
            var characterWizard = new CharacterWizard()
            {
                Races = _raceService.GetRaces(),
                Classes = _classService.GetClasses(),
                Character = new Character()
            };

            return characterWizard;
        }
    }
}