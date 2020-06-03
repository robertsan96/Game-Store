using Game_Store.Models;
using System;
using System.Collections.Generic;

namespace Game_Store.Data
{
    public class MockRepository : IGameStoreRepository
    {
        public Game GetGameById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game
                {
                    Name="Shadow of the Tomb Raider",
                    Description="Game of the year.",
                    ReleaseDate=DateTime.Now
                }
            };
        }
    }
}
