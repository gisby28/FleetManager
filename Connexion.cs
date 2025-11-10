using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace csharpBDD
{
    internal class CnxConfig
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
                    Console.WriteLine("Connexion réussie");
                    return cnx;
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Erreur de connexion : " + e.Message);
                }
                return null;
            }
        }
        }
    }