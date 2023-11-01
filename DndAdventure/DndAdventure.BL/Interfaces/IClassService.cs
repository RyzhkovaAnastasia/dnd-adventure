using DndAdventure.Models.Models;

namespace DndAdventure.BL.Interfaces
{
    public interface IClassService
    {

        List<Class> GetClasses();

        Class GetClass(string name);
    }
}