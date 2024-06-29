namespace Form_Inicio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_Plarer2 = new Label();
            lbl_player1 = new Label();
            SuspendLayout();
            // 
            // lbl_Plarer2
            // 
            lbl_Plarer2.AutoSize = true;
            lbl_Plarer2.BackColor = Color.RosyBrown;
            lbl_Plarer2.FlatStyle = FlatStyle.Flat;
            lbl_Plarer2.Font = new Font("Kristen ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Plarer2.ForeColor = SystemColors.Desktop;
            lbl_Plarer2.Location = new Point(742, 58);
            lbl_Plarer2.Name = "lbl_Plarer2";
            lbl_Plarer2.Size = new Size(118, 28);
            lbl_Plarer2.TabIndex = 0;
            lbl_Plarer2.Text = "Jugador 2";
            lbl_Plarer2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Plarer2.Click += label1_Click;
            // 
            // lbl_player1
            // 
            lbl_player1.AutoSize = true;
            lbl_player1.BackColor = Color.RosyBrown;
            lbl_player1.FlatStyle = FlatStyle.Flat;
            lbl_player1.Font = new Font("Kristen ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player1.ForeColor = SystemColors.Desktop;
            lbl_player1.Location = new Point(76, 58);
            lbl_player1.Name = "lbl_player1";
            lbl_player1.Size = new Size(117, 28);
            lbl_player1.TabIndex = 1;
            lbl_player1.Text = "Jugador 1";
            lbl_player1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(979, 490);
            Controls.Add(lbl_player1);
            Controls.Add(lbl_Plarer2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Plarer2;
        private Label lbl_player1;
    }
}
