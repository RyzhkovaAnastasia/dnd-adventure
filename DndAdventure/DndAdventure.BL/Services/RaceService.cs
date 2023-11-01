using DndAdventure.BL.Interfaces;
using DndAdventure.Models.Models;

namespace DndAdventure.BL.Services
{
    public class RaceService : IRaceService
    {

        public List<Race> GetRaces()
        {
            return new List<Race>
            {
                new Race { Name = "Elf", Description = "Elf desc" },
                new Race { Name = "Ork", Description = "Ork desc" },
            };
        }

        public Race GetRace(string name)
        {
            return new Race { Name = "Elf", Description = "Elf desc" };
        }
    }
}