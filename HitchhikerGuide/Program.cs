using System;
using System.Windows.Forms;
using HitchhikerGuide.Data;
using HitchhikerGuide.Data.PublisherClient;
using HitchhikerGuide.WinForms;

namespace HitchhikerGuide
{
    internal static class Program
    {
        public static readonly IRepository Repository = new Repository();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
