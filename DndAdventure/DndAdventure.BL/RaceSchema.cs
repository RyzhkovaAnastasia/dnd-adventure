using DndAdventure.BL.QueryTypes;
using GraphQL.Instrumentation;
using GraphQL.Types;

namespace DndAdventure.Models
{
    public class RaceSchema : Schema
    {
        public RaceSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = (RaceQueryType)provider.GetService(typeof(RaceQueryType));
           
            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
