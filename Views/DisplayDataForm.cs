using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetManager.Views
{
    public partial class DisplayDataForm : Form
    {
        private User utilisateurActuel;
        private Controller appController;
        public DisplayDataForm(User user)
        {
            InitializeComponent();

            this.utilisateurActuel = user;
            this.appController = new Controller(); // Le MainForm a aussi besoin du contrôleur

            // Vous pouvez maintenant utiliser l'utilisateur
            this.Text = "FleetManager - Connecté : " + utilisateurActuel.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
