using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace FleetManager
{
    internal class Method
    {
        // Méthode connexion
        public MySqlConnection connecter()
        {
            // String connexion à la bdd
            string cnxString = "Server=localhost;Database=fleetmanager;Uid=root;Pwd=;";
            var cnx = new MySqlConnection(cnxString);
            {
                try
                {
                    cnx.Open();
                    MessageBox.Show("Connexion réussie");
                    return cnx;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur de connexion : " + e.Message);
                }
                return null;
            }
        }


        // Méthode insertion users
        public void insertUser(int user_id, string username, string password, string role, MySqlConnection msc)
        {
            string req = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
            using (var insert = new MySqlCommand(req, msc))
            {
                insert.Parameters.AddWithValue("@username", username);
                insert.Parameters.AddWithValue("@password", password);
                insert.Parameters.AddWithValue("@role", role);

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur inséré avec succès");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de l'insertion : " + e.Message);
                }
            }
        }

        // Méthode affichage des users
        public void selectUsers(MySqlConnection msc)
        {
            string req = "SELECT user_id, username, password, role FROM users";
            using (var cmd = new MySqlCommand(req, msc))
            {
                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Aucun utilisateur trouvé.");
                            return;
                        }


                        while (reader.Read())
                        {
                            int user_id = reader.GetInt32("user_id");
                            string username = reader.GetString("nom");
                            string password = reader.GetString("prenom");
                            string role = reader.GetString("role");

                        }
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de l'affichage: " + e.Message);
                }
            }
        }


        // Méthode suppression des users
        public void deleteUser(int user_id, MySqlConnection msc)
        {
            string req = "DELETE FROM users WHERE user_id = @user_id";
            using (var delete = new MySqlCommand(req, msc))
            {
                delete.Parameters.AddWithValue("@user_id", user_id);
                try
                {
                    int rowsAffected = delete.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Utilisateur supprimé avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Aucun utilisateur trouvé avec cet ID");
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de la suppression : " + e.Message);
                }
            }
        }

        // Méthode mise à jour des users
        public void updateUser(int user_id, string username, string password, string role, MySqlConnection msc)
        {
            string req = "UPDATE users SET username = @username, password = @password, role = @role WHERE user_id = @user_id";
            using (var update = new MySqlCommand(req, msc))
            {
                update.Parameters.AddWithValue("@username", username);
                update.Parameters.AddWithValue("@password", password);
                update.Parameters.AddWithValue("@role", role);
                update.Parameters.AddWithValue("@user_id", user_id);
                try
                {
                    int rowsAffected = update.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Utilisateur mis à jour avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Aucun utilisateur trouvé avec cet ID");
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de la mise à jour : " + e.Message);
                }
            }
        }



        // Méthode insertion véhicules
        public void insertVehicule(string immatriculation, string modele, string description, int kilometrage_total, decimal prix_litre, MySqlConnection msc)
        {
            string req = "INSERT INTO vehicules (immatriculation, modele, description, kilometrage_total, prix_litre) VALUES (@immatriculation, @modele, @description, @kilometrage_total, @prix_litre)";
            using (var insert = new MySqlCommand(req, msc))
            {
                insert.Parameters.AddWithValue("@immatriculation", immatriculation);
                insert.Parameters.AddWithValue("@modele", modele);
                insert.Parameters.AddWithValue("@description", description);
                insert.Parameters.AddWithValue("@kilometrage_total", kilometrage_total);
                insert.Parameters.AddWithValue("@prix_litre", prix_litre);


                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Véhicule inséré avec succès");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de l'insertion : " + e.Message);
                }
            }
        }

        // Méthode affichage des véhicules
        public void selectVehicules(MySqlConnection msc)
        {
            string req = "SELECT vehicule_id, immatriculation, modele, description, kilometrage_total, prix_litre FROM vehicules";
            using (var cmd = new MySqlCommand(req, msc))
            {
                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Aucun véhicule trouvé.");
                            return;
                        }
                        while (reader.Read())
                        {
                            int vehicule_id = reader.GetInt32("vehicule_id");
                            string immatriculation = reader.GetString("immatriculation");
                            string modele = reader.GetString("modele");
                            string description = reader.GetString("description");
                            int kilometrage_total = reader.GetInt32("kilometrage_total");
                            decimal prix_litre = reader.GetDecimal("prix_litre");
                        }
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de l'affichage: " + e.Message);

                }
            }
        }

        // Méthode suppression des véhicules
        public void deleteVehicule(int vehicule_id, MySqlConnection msc)
        {
            string req = "DELETE FROM vehicules WHERE vehicule_id = @vehicule_id";
            using (var delete = new MySqlCommand(req, msc))
            {
                delete.Parameters.AddWithValue("@vehicule_id", vehicule_id);
                try
                {
                    int rowsAffected = delete.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Véhicule supprimé avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Aucun véhicule trouvé avec cet ID");
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de la suppression : " + e.Message);
                }
            }
        }

        // Méthode mise à jour des véhicules
        public void updateVehicule(int vehicule_id, string immatriculation, string modele, string description, int kilometrage_total, decimal prix_litre, MySqlConnection msc)
        {
            string req = "UPDATE vehicules SET immatriculation = @immatriculation, modele = @modele, description = @description, kilometrage_total = @kilometrage_total, prix_litre = @prix_litre WHERE vehicule_id = @vehicule_id";
            using (var update = new MySqlCommand(req, msc))
            {
                update.Parameters.AddWithValue("@immatriculation", immatriculation);
                update.Parameters.AddWithValue("@modele", modele);
                update.Parameters.AddWithValue("@description", description);
                update.Parameters.AddWithValue("@kilometrage_total", kilometrage_total);
                update.Parameters.AddWithValue("@prix_litre", prix_litre);
                update.Parameters.AddWithValue("@vehicule_id", vehicule_id);
                try
                {
                    int rowsAffected = update.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Véhicule mis à jour avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Aucun véhicule trouvé avec cet ID");
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur SQL lors de la mise à jour : " + e.Message);
                }
            }
        }
    }
}