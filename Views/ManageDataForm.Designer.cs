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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(300, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(488, 383);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 155);
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
            // button1
            // 
            button1.Location = new Point(13, 210);
            button1.Name = "button1";
            button1.Size = new Size(119, 32);
            button1.TabIndex = 3;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(144, 210);
            button2.Name = "button2";
            button2.Size = new Size(119, 32);
            button2.TabIndex = 4;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 258);
            button3.Name = "button3";
            button3.Size = new Size(119, 32);
            button3.TabIndex = 5;
            button3.Text = "Ajouter";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(144, 258);
            button4.Name = "button4";
            button4.Size = new Size(119, 32);
            button4.TabIndex = 6;
            button4.Text = "Annuler";
            button4.UseVisualStyleBackColor = true;
            // 
            // ManageDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "ManageDataForm";
            Text = "ManageDataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}