using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Game_Store.Data;
using Game_Store.Dtos;
using Game_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game_Store.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameStoreRepository _repository;
        private readonly IMapper _mapper;

        public GameController(IGameStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameReadDto>> GetGames()
        {
            var games = _repository.GetGames();

            return Ok(_mapper.Map<IEnumerable<GameReadDto>>(games));

        }
    }
}
