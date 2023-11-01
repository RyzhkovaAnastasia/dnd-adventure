using DndAdventure.Models.Models;
using GraphQL.Types;

namespace DndAdventure.Models.ObjectGraphTypes
{
    public class RaceType : ObjectGraphType<Race>
    {
        public RaceType()
        {
            Name = "Race";

            Field(r => r.Name).Description("The name of the race.");
            Field(r => r.Description).Description("The race description.");
            Field(r => r.Traits, type: typeof(ListGraphType<TraitType>)).Description("The list of race features.");
            Field(r => r.Speed).Description("The length of the maximum distance a character can move.");
            Field(r => r.Languages).Description("Languages character can speak.");
        }
    }
}
