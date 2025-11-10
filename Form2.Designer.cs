namespace FleetManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            displayTables = new ListBox();
            buttonGerer = new Button();
            displayStats = new Button();
            buttonDisplayData = new Button();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 390);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 3;
            label1.Text = "Séléctionner une table";
            // 
            // displayTables
            // 
            displayTables.FormattingEnabled = true;
            displayTables.Location = new Point(12, 48);
            displayTables.Name = "displayTables";
            displayTables.Size = new Size(256, 104);
            displayTables.TabIndex = 5;
            // 
            // buttonGerer
            // 
            buttonGerer.Location = new Point(12, 173);
            buttonGerer.Name = "buttonGerer";
            buttonGerer.Size = new Size(256, 38);
            buttonGerer.TabIndex = 6;
            buttonGerer.Text = "Gérer";
            buttonGerer.UseVisualStyleBackColor = true;
            // 
            // displayStats
            // 
            displayStats.Location = new Point(12, 340);
            displayStats.Name = "displayStats";
            displayStats.Size = new Size(256, 54);
            displayStats.TabIndex = 8;
            displayStats.Text = "Afficher les statistiques sur les véhicules";
            displayStats.UseVisualStyleBackColor = true;
            // 
            // buttonDisplayData
            // 
            buttonDisplayData.Location = new Point(12, 217);
            buttonDisplayData.Name = "buttonDisplayData";
            buttonDisplayData.Size = new Size(256, 38);
            buttonDisplayData.TabIndex = 9;
            buttonDisplayData.Text = "Afficher les données en détail";
            buttonDisplayData.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(256, 38);
            button1.TabIndex = 10;
            button1.Text = "Se déconnecter";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 12);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 11;
            label2.Text = "Données de la table";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonDisplayData);
            Controls.Add(displayStats);
            Controls.Add(buttonGerer);
            Controls.Add(displayTables);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button displayStats;
        private Label label1;
        private ListBox displayTables;
        private Button buttonGerer;
        private Button buttonDisplayData;
        private Button button1;
        private Label label2;
    }
}