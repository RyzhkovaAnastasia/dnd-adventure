using DndAdventure.BL.Interfaces;
using DndAdventure.Models.ObjectGraphTypes;
using GraphQL;
using GraphQL.Types;

namespace DndAdventure.BL.QueryTypes
{
    public class RaceQueryType : ObjectGraphType
    {
        [Obsolete]
        public RaceQueryType(IRaceService raceService)
        {
            Field<RaceType>(
            "race",
            arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "name" }),
            resolve: context =>
            {
                var raceName = context.GetArgument<string>("name");
                return raceService.GetRace(raceName);
            }
        );

            Field<ListGraphType<RaceType>>(
            "races",
            resolve: context =>
            {
               return raceService.GetRaces();
            }
       );
        }
    }
}
