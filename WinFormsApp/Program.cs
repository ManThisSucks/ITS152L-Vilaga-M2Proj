using AudioDataLibrary.Data;
using BlogDataLibrary.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    internal static class Program
    {
        
        private static CancellationTokenSource _cancellationTokenSource;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => StartApiServer(_cancellationTokenSource.Token));

            ApplicationConfiguration.Initialize();
            SqlData db = GetConnection();
            Application.Run(new ItemListing(db));

            // When the WinForms application closes, trigger the cancellation token
            _cancellationTokenSource.Cancel();
        }

        static void StartApiServer(CancellationToken token)
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllers();
            builder.Services.AddScoped<SqlData>();
            builder.Services.AddScoped<ISqlDataAccess, SqlDataAccess>();

            var app = builder.Build();

            // Configure endpoints and middleware
            app.MapControllers();

            // Run the application in a separate task, observing the cancellation token
            app.RunAsync(token).Wait();
        }

        static SqlData GetConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();
            ISqlDataAccess dbAccess = new SqlDataAccess(config);
            SqlData db = new SqlData(dbAccess);

            return db;
        }
    }
}