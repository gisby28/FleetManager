using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Windows.Forms;
using FleetManager.Controllers;
using FleetManager.Models;

namespace FleetManager.Views
{
    public partial class ConnexionForm : Form
    {
        private Controller appController;

        public ConnexionForm()
        {
            InitializeComponent();
            appController = new Controller();
        }

        private void connexionButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User userConnecte = appController.TenterConnexion(username, password);

            if (userConnecte != null)
            {
                MessageBox.Show($"Bienvenue, {userConnecte.Username} (Rôle : {userConnecte.Role})");

                DisplayDataForm displayDataForm = new DisplayDataForm(userConnecte);
                displayDataForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.",
                                "Erreur de connexion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
