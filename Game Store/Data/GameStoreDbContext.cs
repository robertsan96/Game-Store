using Game_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Game_Store.Data
{
    public class GameStoreDbContext : DbContext
    {

        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> opt) : base(opt)
        {

        }

        public DbSet<Game> Game { get; set; }

    }
}
