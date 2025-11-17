using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace FleetManager
{
    internal class Controller
    {
        private DataService dataService;

        public Controller()
        {
            this.dataService = new DataService();
        }
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
    }
}
