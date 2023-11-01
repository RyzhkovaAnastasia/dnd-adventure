using DndAdventure.Models.Models;

namespace DndAdventure.BL.Interfaces
{
    public interface IRaceService
    {
        List<Race> GetRaces();

        Race GetRace(string name);
    }
}