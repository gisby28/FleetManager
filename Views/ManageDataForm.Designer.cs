namespace FleetManager.Views
{
    partial class ManageDataForm
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
            label1 = new Label();
            label2 = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            cancelButton = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 51);
            label1.Name = "label1";
            label1.Size = new Size(237, 23);
            label1.TabIndex = 1;
            label1.Text = "Choisir l'action à effectuer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 12);
            label2.Name = "label2";
            label2.Size = new Size(349, 26);
            label2.TabIndex = 2;
            label2.Text = "Données de l'élément séléctionné";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(23, 87);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(210, 41);
            updateButton.TabIndex = 3;
            updateButton.Text = "Modifier";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(264, 87);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(212, 41);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Supprimer";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(22, 134);
            addButton.Name = "addButton";
            addButton.Size = new Size(211, 42);
            addButton.TabIndex = 5;
            addButton.Text = "Ajouter";
            addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(264, 134);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(210, 42);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Annuler";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 195);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(474, 201);
            dataGridView1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(502, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(286, 345);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // ManageDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageDataForm";
            Text = "ManageDataForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button updateButton;
        private Button deleteButton;
        private Button addButton;
        private Button cancelButton;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}