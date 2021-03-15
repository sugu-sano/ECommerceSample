using System;

namespace ECommerceSample.WebApi
{
    /// <summary>
    /// 天気予報
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// 日付
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 摂氏
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// 華氏
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// 概要
        /// </summary>
        public string Summary { get; set; }
    }
}
