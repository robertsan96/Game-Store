using Game_Store.Models;
using System;
using System.Collections.Generic;

namespace Game_Store.Data
{
    public class MockRepository : IGameStoreRepository
    {
        public Game GetGameById(int id)
        {
            return new Game
            {
                Name = "Shadow of the Tomb Raider",
                Description = "Game of the year.",
                ReleaseDate = DateTime.Now
            };
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
                },
                new Game
                {
                    Name="Mafia III",
                    Description="Awesome graphics & story.",
                    ReleaseDate=DateTime.Parse("2019-05-08")
                }
            };
        }

        public void CreateGame(Game game) { }

        public void SaveChanges()
        {

        }
    }
}
