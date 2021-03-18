using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceSample.WebApi.Controllers
{
    /// <summary>
    /// 天気予報APIコントローラー
    /// </summary>
    public class WeatherForecastController : ApiControllerBaseV1
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// 天気予報APIコントローラー
        /// </summary>
        /// <param name="logger">ロガー</param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// 天気予報の一覧を取得する
        /// </summary>
        /// <returns>天気予報の一覧</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
