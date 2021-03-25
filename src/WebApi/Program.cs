using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

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
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        /// <summary>
        /// ホストビルダーを作成する
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        /// <returns>ホストビルダー</returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

            return hostBuilder;
        }
    }
}
