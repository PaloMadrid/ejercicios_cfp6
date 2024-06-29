namespace formularios
{
    partial class FormEscribir
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
            txbx_texto = new TextBox();
            label1 = new Label();
            btn_escribir = new Button();
            btn_cancelar = new Button();
            lst_lapiceras = new ListBox();
            SuspendLayout();
            // 
            // txbx_texto
            // 
            txbx_texto.Location = new Point(47, 146);
            txbx_texto.Name = "txbx_texto";
            txbx_texto.Size = new Size(681, 23);
            txbx_texto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 113);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 1;
            label1.Text = "Escriba el texto que quiera:";
            // 
            // btn_escribir
            // 
            btn_escribir.Location = new Point(161, 197);
            btn_escribir.Name = "btn_escribir";
            btn_escribir.Size = new Size(75, 23);
            btn_escribir.TabIndex = 2;
            btn_escribir.Text = "Escribir";
            btn_escribir.UseVisualStyleBackColor = true;
            btn_escribir.Click += btn_escribir_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(548, 197);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lst_lapiceras
            // 
            lst_lapiceras.FormattingEnabled = true;
            lst_lapiceras.ItemHeight = 15;
            lst_lapiceras.Location = new Point(136, 26);
            lst_lapiceras.Name = "lst_lapiceras";
            lst_lapiceras.Size = new Size(522, 64);
            lst_lapiceras.TabIndex = 4;
            // 
            // FormEscribir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 239);
            Controls.Add(lst_lapiceras);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_escribir);
            Controls.Add(label1);
            Controls.Add(txbx_texto);
            Name = "FormEscribir";
            Text = "FormEscribir";
            Load += FormEscribir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbx_texto;
        private Label label1;
        private Button btn_escribir;
        private Button btn_cancelar;
        private ListBox lst_lapiceras;
    }
}