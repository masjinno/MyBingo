using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBingoServer.Models;

namespace MyBingoServer.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BingoController : ControllerBase
    {
        private readonly ILogger<BingoController> _logger;

        public BingoController(ILogger<BingoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("game")]
        public GameInfo GetGame()
        {
            GameInfo game = new GameInfo();
            game.Numbers = new int[] { 20, 25, 74, 31 };
            return game;

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
