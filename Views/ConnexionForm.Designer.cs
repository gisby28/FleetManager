namespace FleetManager.Views
{
    partial class ConnexionForm
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
            connexionButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // connexionButton
            // 
            connexionButton.BackColor = SystemColors.Highlight;
            connexionButton.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connexionButton.ForeColor = SystemColors.ButtonHighlight;
            connexionButton.Location = new Point(428, 410);
            connexionButton.Name = "connexionButton";
            connexionButton.Size = new Size(163, 40);
            connexionButton.TabIndex = 17;
            connexionButton.Text = "Se connecter";
            connexionButton.UseVisualStyleBackColor = false;
            connexionButton.Click += connexionButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 109);
            label3.Name = "label3";
            label3.Size = new Size(191, 40);
            label3.TabIndex = 16;
            label3.Text = "Connexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 305);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 187);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(237, 338);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(354, 36);
            passwordTextBox.TabIndex = 13;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(237, 220);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(354, 36);
            usernameTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoFM;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // ConnexionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 497);
            Controls.Add(pictureBox1);
            Controls.Add(connexionButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "ConnexionForm";
            Text = "ConnexionForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connexionButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private PictureBox pictureBox1;
    }
}