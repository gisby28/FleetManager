using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using FleetManager.Services;

namespace FleetManager.Views
{
    public partial class ManageDataForm : Form
    {
        private User utilisateurActuel;
        private string nomTable;
        private DataService dataService;

        private MySqlDataAdapter dataAdapter;
        private MySqlCommandBuilder commandBuilder;
        private DataTable dataTable;
        private BindingSource bindingSource;

        private Dictionary<string, TextBox> editorTextBoxes = new Dictionary<string, TextBox>();
        private bool isAddingNew = false;

        public ManageDataForm(User user, string tableName)
        {
            InitializeComponent();

            this.utilisateurActuel = user;
            this.nomTable = tableName;
            this.dataService = new DataService();

            this.Text = $"FleetManager - Gestion : {tableName}";

            this.Load += ManageDataForm_Load;
            this.FormClosed += ManageDataForm_FormClosed;
        }

        private void ManageDataForm_Load(object sender, EventArgs e)
        {
            if (!LoadData())
            {
                this.Close();
                return;
            }
            PopulateEditorControls();
            BindControlsToData();

            this.dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.addButton.Click += addButton_Click;
            this.deleteButton.Click += deleteButton_Click;
            this.updateButton.Click += updateButton_Click;
            this.cancelButton.Click += (s, ev) => this.Close();
        }

        private bool LoadData()
        {
            try
            {
                MySqlConnection conn = dataService.GetConnection();

                string query = $"SELECT * FROM `{nomTable}`";
                dataAdapter = new MySqlDataAdapter(query, conn);
                commandBuilder = new MySqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                conn.Close();

                bindingSource = new BindingSource { DataSource = dataTable };
                dataGridView1.DataSource = bindingSource;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur critique lors du chargement des données pour '{nomTable}': {ex.Message}\n\nAssurez-vous que cette table possède une clé primaire.", "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PopulateEditorControls()
        {
            flowLayoutPanel1.Controls.Clear();
            editorTextBoxes.Clear();

            foreach (DataColumn column in dataTable.Columns)
            {
                Label label = new Label
                {
                    Text = column.ColumnName + " :",
                    AutoSize = true,
                    Margin = new Padding(3, 6, 3, 3)
                };

                TextBox textBox = new TextBox
                {
                    Name = "txt_" + column.ColumnName,
                    Width = 200
                };

                if (column.AutoIncrement)
                {
                    textBox.ReadOnly = true;
                    textBox.BackColor = System.Drawing.Color.LightGray;
                }

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(textBox);
                editorTextBoxes.Add(column.ColumnName, textBox);
            }
        }
        private void BindControlsToData()
        {
            foreach (var pair in editorTextBoxes)
            {
                string columnName = pair.Key;
                TextBox textBox = pair.Value;

                textBox.DataBindings.Clear();
                textBox.DataBindings.Add("Text",
                    bindingSource,
                    columnName,
                    true,
                    DataSourceUpdateMode.OnValidation,
                    "");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.AddNew();
                isAddingNew = true;

                foreach (var tb in editorTextBoxes.Values)
                {
                    if (!tb.ReadOnly)
                    {
                        tb.Focus();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?\nL'action est immédiate.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                EnregistrerModifications();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EnregistrerModifications();
        }

        private void EnregistrerModifications()
        {
            try
            {
                this.bindingSource.EndEdit();

                this.Validate();

                int rowsAffected = dataAdapter.Update(dataTable);

                MessageBox.Show($"{rowsAffected} ligne(s) enregistrée(s).", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isAddingNew = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}\nVérifiez que tous les champs requis sont remplis.", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                bindingSource.CancelEdit();
                isAddingNew = false;
            }
        }

        private void ManageDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form displayForm = Application.OpenForms["DisplayDataForm"];
            displayForm?.Show();
        }
    }
}