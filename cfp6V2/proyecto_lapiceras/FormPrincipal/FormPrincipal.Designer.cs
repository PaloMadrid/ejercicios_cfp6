namespace FormPrincipal
{
    partial class FormPrincipal
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
            dtg_lapiceras = new DataGridView();
            btn_agregar = new Button();
            btn_escribir = new Button();
            btn_mostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_lapiceras).BeginInit();
            SuspendLayout();
            // 
            // dtg_lapiceras
            // 
            dtg_lapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_lapiceras.Location = new Point(23, 25);
            dtg_lapiceras.Name = "dtg_lapiceras";
            dtg_lapiceras.Size = new Size(762, 339);
            dtg_lapiceras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(228, 401);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_escribir
            // 
            btn_escribir.Location = new Point(477, 401);
            btn_escribir.Name = "btn_escribir";
            btn_escribir.Size = new Size(75, 23);
            btn_escribir.TabIndex = 1;
            btn_escribir.Text = "Escribir";
            btn_escribir.UseVisualStyleBackColor = true;
            btn_escribir.Click += btn_escribir_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(352, 401);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 1;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(btn_escribir);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_agregar);
            Controls.Add(dtg_lapiceras);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_lapiceras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_lapiceras;
        private Button btn_agregar;
        private Button btn_escribir;
        private Button btn_mostrar;
    }
}
