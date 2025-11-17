using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Dans /Views/ConnexionForm.cs

using System;
using System.Windows.Forms;

namespace FleetManager.Views // Assurez-vous que le namespace est correct
{
    public partial class ConnexionForm : Form
    {
        // Le formulaire de connexion a besoin d'une référence au contrôleur
        private Controller appController;

        public ConnexionForm()
        {
            InitializeComponent();
            // On initialise le contrôleur
            appController = new Controller();
        }

        private void connexionButton_Click(object sender, EventArgs e)
        {
            // 1. Récupérer les données de la Vue
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // 2. Appeler le Contrôleur
            User userConnecte = appController.TenterConnexion(username, password);

            // 3. Gérer la réponse
            if (userConnecte != null)
            {
                // Succès !
                MessageBox.Show($"Bienvenue, {userConnecte.Username} (Rôle : {userConnecte.Role})");

                // On crée le formulaire principal en lui passant l'utilisateur
                DisplayDataForm displayDataForm = new DisplayDataForm(userConnecte);
                displayDataForm.Show();

                // On cache ce formulaire de connexion
                this.Hide();
            }
            else
            {
                // Échec
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.",
                                "Erreur de connexion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
