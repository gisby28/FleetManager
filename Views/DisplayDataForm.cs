using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FleetManager.Controllers;


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

            this.appController = new Controller();

            this.Text = "FleetManager - Connecté : " + utilisateurActuel.Username;

            this.Load += new EventHandler(DisplayDataForm_Load);
            this.listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            this.button1.Click += new EventHandler(button1_Click);

            this.VisibleChanged += new EventHandler(DisplayDataForm_VisibleChanged);
        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {
            LoadTableNames();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string tableName = listBox1.SelectedItem.ToString();
                LoadTableData(tableName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une table.", "Aucune table choisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomTableSelectionnee = listBox1.SelectedItem.ToString();

            ManageDataForm manageForm = new ManageDataForm(this.utilisateurActuel, nomTableSelectionnee);

            manageForm.Show();
            this.Hide();
        }

        private void DisplayDataForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && listBox1.SelectedItem != null)
            {
                LoadTableData(listBox1.SelectedItem.ToString());
            }
        }

        private void LoadTableNames()
        {
            try
            {
                List<string> tableNames = this.appController.GetTableNames();

                listBox1.Items.Clear();

                foreach (string name in tableNames)
                {
                    listBox1.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des noms de tables : {ex.Message}", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTableData(string tableName)
        {
            try
            {
                DataTable data = this.appController.GetTableData(tableName);

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données pour la table '{tableName}' : {ex.Message}", "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}