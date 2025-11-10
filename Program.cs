// Dans Program.cs

using FleetManager.Views; // N'oubliez pas le "using" pour le dossier Views
using System;
using System.Windows.Forms;

namespace FleetManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // On lance le formulaire de connexion en premier
            Application.Run(new ConnexionForm());
        }
    }
}