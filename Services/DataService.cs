using System;
using System.Collections.Generic;
using MySqlConnector;

namespace FleetManager
{
    internal class DataService
    {
        private string cnxString = "Server=localhost;Database=fleetmanager;Uid=root;Pwd=;";

        // Méthode sélection users
        public List<User> SelectUsers()
        {
            var userList = new List<User>();
            string req = "SELECT user_id, username, password, role FROM users";

            using (var msc = new MySqlConnection(cnxString))
            {
                try
                {
                    msc.Open();
                    using (var cmd = new MySqlCommand(req, msc))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User
                            {
                                UserId = reader.GetInt32("user_id"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password"),
                                Role = reader.GetString("role")
                            };
                            userList.Add(user);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Erreur SQL (SelectUsers): " + e.Message);
                }
            }
            return userList; 
        }

        // Méthode insertion users
        public bool InsertUser(string username, string password, string role)
        {
            string req = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";

            using (var msc = new MySqlConnection(cnxString))
            {
                try
                {
                    msc.Open();
                    using (var insert = new MySqlCommand(req, msc))
                    {
                        insert.Parameters.AddWithValue("@username", username);
                        insert.Parameters.AddWithValue("@password", password);
                        insert.Parameters.AddWithValue("@role", role);

                        int rowsAffected = insert.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Erreur SQL (InsertUser): " + e.Message);
                    return false;
                }
            }
        }
    }
}