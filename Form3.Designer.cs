namespace FleetManager
{
    partial class Form3
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
            statsView = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)statsView).BeginInit();
            SuspendLayout();
            // 
            // statsView
            // 
            statsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statsView.Location = new Point(12, 44);
            statsView.Name = "statsView";
            statsView.RowHeadersWidth = 51;
            statsView.Size = new Size(776, 301);
            statsView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 23);
            label1.TabIndex = 1;
            label1.Text = "Statistiques sur les véhicules";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F);
            button1.Location = new Point(442, 360);
            button1.Name = "button1";
            button1.Size = new Size(142, 69);
            button1.TabIndex = 2;
            button1.Text = "L / 100Km";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(218, 360);
            button2.Name = "button2";
            button2.Size = new Size(142, 69);
            button2.TabIndex = 3;
            button2.Text = "€ / Km";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9F);
            button3.Location = new Point(12, 360);
            button3.Name = "button3";
            button3.Size = new Size(140, 69);
            button3.TabIndex = 4;
            button3.Text = "Total € dépensés / Véhicule";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 9F);
            button4.Location = new Point(647, 360);
            button4.Name = "button4";
            button4.Size = new Size(141, 69);
            button4.TabIndex = 5;
            button4.Text = "Nombre d'utilisations";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(317, 435);
            button5.Name = "button5";
            button5.Size = new Size(154, 29);
            button5.TabIndex = 6;
            button5.Text = "Retour";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 471);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(statsView);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)statsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView statsView;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}