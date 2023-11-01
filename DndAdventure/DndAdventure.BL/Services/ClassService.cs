using DndAdventure.BL.Interfaces;
using DndAdventure.Models.Models;

namespace DndAdventure.BL.Services
{
    public class ClassService : IClassService
    {

        public Class GetClass(string name)
        {
            return new Class();
        }

        public List<Class> GetClasses()
        {
            return new List<Class>();
        }
    }
}
