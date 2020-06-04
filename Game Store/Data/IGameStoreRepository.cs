using Game_Store.Dtos;
using Game_Store.Models;
using System.Collections.Generic;

namespace Game_Store.Data
{
    public interface IGameStoreRepository
    {
        IEnumerable<Game> GetGames();
        Game GetGameById(int id);
        void CreateGame(Game game);
        void SaveChanges();
    }
}
