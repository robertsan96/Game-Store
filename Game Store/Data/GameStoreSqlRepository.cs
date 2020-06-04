using Game_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Store.Data
{
    public class GameStoreSqlRepository : IGameStoreRepository
    {
        protected readonly GameStoreDbContext _context;
        public GameStoreSqlRepository(GameStoreDbContext context)
        {
            _context = context;
        }
        public void CreateGame(Game game)
        {
            _context.Game.Add(game);
        }

        public Game GetGameById(int id)
        {
            return _context.Game.Find(id);
        }

        public IEnumerable<Game> GetGames()
        {
            return _context.Game.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
