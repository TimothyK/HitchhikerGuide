using HitchhikerGuide.Data;
using HitchhikerGuide.Data.PublisherClient;
using HitchhikerGuide.WinForms;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.IO;
using System.Windows.Forms;

namespace HitchhikerGuide
{
    internal static class Program
    {
        public static IRepository Repository { get; private set; }
        public static ILoggerFactory LoggerFactory { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            InitializeLogging();
            LoggerFactory.CreateLogger("Startup").LogInformation("Starting program");
            Repository = new Repository(LoggerFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void InitializeLogging()
        {
            var filename = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                , "Hitchhiker"
                , "{Date} Hitchhiker.log");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .Enrich.WithProcessId()
                .Enrich.WithThreadId()
                .Enrich.WithAssemblyName()
                .Enrich.WithAssemblyVersion()
                .WriteTo.RollingFile(filename)
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();

            LoggerFactory = new LoggerFactory()
                .AddSerilog();
        }
    }
}
