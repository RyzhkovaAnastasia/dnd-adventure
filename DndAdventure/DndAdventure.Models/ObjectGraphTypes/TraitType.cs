using DndAdventure.Models.Models;
using GraphQL.Types;

namespace DndAdventure.Models.ObjectGraphTypes
{
    public class TraitType : ObjectGraphType<Trait>
    {
        public TraitType()
        {
            Name = "Trait";

            Field(r => r.Name).Description("The name of the trait.");
            Field(r => r.Description).Description("The trait description.");
        }
    }
}
