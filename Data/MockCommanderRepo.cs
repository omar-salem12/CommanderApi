using System.Collections.Generic;
using Commandar.Models;

namespace Commandar.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id =0,HowTo="Boi an egg", Line="Bli water", platform="kettie & pan"},
                new Command{Id =1,HowTo="cut bread", Line="Get a knifa", platform="knife & chopping board"},
                new Command{Id =2,HowTo="Make  cup of tea", Line="place teabag in cup", platform="kettie & pan"},
                
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id =0,HowTo="Boi an egg", Line="Bli water", platform="kettie & pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}