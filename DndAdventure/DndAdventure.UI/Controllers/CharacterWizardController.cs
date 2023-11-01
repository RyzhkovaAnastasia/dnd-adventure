using DndAdventure.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DndAdventure.UI.Controllers
{
    public class CharacterWizardController : Controller
    {
        private readonly ICharacterWizardService _characterWizard;
        public CharacterWizardController(ICharacterWizardService characterWizard)
        {
            _characterWizard = characterWizard;
        }

        public ActionResult Index()
        {
            var wizard = _characterWizard.NewCharacterWizard();
            return View(wizard);
        }
    }
}
