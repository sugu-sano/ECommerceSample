using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ECommerceSample.WebApi
{
    /// <summary>
    /// メインクラス
    /// </summary>
    public class Program
    {
        /// <summary>
        /// エントリーポイント
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        /// <summary>
        /// ホストビルダーを作成する
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        /// <returns>ホストビルダー</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
