using System;
using System.Collections.Generic;
using System.Data;          // <-- Ajouté : Pour utiliser DataTable
using MySqlConnector;     // <-- Ajouté : Pour MySqlCommand, etc.
using FleetManager.Services;  // <-- Ajouté : Pour trouver DataService

namespace FleetManager.Controllers
{
    // Doit être 'public' pour être vu par vos formulaires (Views)
    public class Controller
    {
        private DataService dataService;

        public Controller()
        {
            this.dataService = new DataService();
        }

        // --- Vos méthodes User (inchangées) ---

        public List<User> GetTousLesUtilisateurs()
        {
            return dataService.SelectUsers();
        }

        public bool CreerNouvelUtilisateur(string username, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            return dataService.InsertUser(username, password, role);
        }

        public User TenterConnexion(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            return dataService.ValiderUtilisateur(username, password);
        }

        // --- NOUVELLES MÉTHODES AJOUTÉES ---

        /// <summary>
        /// Récupère la liste des noms de tables de la base de données.
        /// </summary>
        public List<string> GetTableNames()
        {
            var tableList = new List<string>();
            // Le contrôleur gère la connexion
            // (il utilise la méthode GetConnection() que nous avons ajoutée à DataService)
            using (var conn = dataService.GetConnection())
            {
                string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = DATABASE() ORDER BY table_name";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tableList.Add(reader.GetString(0));
                    }
                }
            }
            return tableList;
        }

        /// <summary>
        /// Récupère toutes les données d'une table spécifique.
        /// </summary>
        public DataTable GetTableData(string tableName)
        {
            var dataTable = new DataTable();
            using (var conn = dataService.GetConnection())
            {
                string query = $"SELECT * FROM `{tableName}`";
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}