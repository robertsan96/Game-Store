using Game_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Store.Data
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-JGNQR3G;Database=GameStoreDB;User Id=GameStore;Password=gamestore;");
        }
    }
}
