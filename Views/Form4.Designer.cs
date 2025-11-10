namespace FleetManager
{
    partial class Form4
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
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnCancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 43);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(161, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(11, 249);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(144, 43);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Ajouter";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(161, 249);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 43);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(331, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(457, 379);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 166);
            label1.Name = "label1";
            label1.Size = new Size(256, 21);
            label1.TabIndex = 6;
            label1.Text = "Séléctionner l'action voulue";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}