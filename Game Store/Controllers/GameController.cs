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

        [HttpGet("{id}", Name="GetGameById")]
        public ActionResult<GameReadDto> GetGameById(int id)
        {
            var game = _repository.GetGameById(id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<GameReadDto>(game));
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameReadDto>> GetGames()
        {
            var games = _repository.GetGames();

            return Ok(_mapper.Map<IEnumerable<GameReadDto>>(games));

        }

        [HttpPost]
        public ActionResult<GameReadDto> CreateGame(GameCreateDto game)
        {
            var gameModel = _mapper.Map<Game>(game);
            _repository.CreateGame(gameModel);
            _repository.SaveChanges();
            var gameReadDto = _mapper.Map<GameReadDto>(gameModel);
            return CreatedAtRoute(nameof(GetGameById), new { Id = gameModel.Id }, gameReadDto);
        }
    }
}
