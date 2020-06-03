using AutoMapper;
using Game_Store.Dtos;
using Game_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Store.Profiles
{
    public class GamesProfile: Profile
    {
        public GamesProfile()
        {
            CreateMap<Game, GameReadDto>();
        }
    }
}
