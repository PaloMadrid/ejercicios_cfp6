namespace FormEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btn_agregar = new Button();
            btn_evaluar = new Button();
            btn_mostrar = new Button();
            lst_estudiantes = new ListBox();
            lbl_alumnos = new Label();
            lbl_informacion = new Label();
            dtg_informacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_informacion).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(65, 415);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_evaluar
            // 
            btn_evaluar.Location = new Point(364, 415);
            btn_evaluar.Name = "btn_evaluar";
            btn_evaluar.Size = new Size(75, 23);
            btn_evaluar.TabIndex = 3;
            btn_evaluar.Text = "Evaluar";
            btn_evaluar.UseVisualStyleBackColor = true;
            btn_evaluar.Click += btn_evaluar_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(515, 415);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 4;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // lst_estudiantes
            // 
            lst_estudiantes.FormattingEnabled = true;
            lst_estudiantes.ItemHeight = 15;
            lst_estudiantes.Location = new Point(23, 60);
            lst_estudiantes.Name = "lst_estudiantes";
            lst_estudiantes.Size = new Size(147, 334);
            lst_estudiantes.TabIndex = 5;
            // 
            // lbl_alumnos
            // 
            lbl_alumnos.AutoSize = true;
            lbl_alumnos.Font = new Font("Segoe UI", 18F);
            lbl_alumnos.Location = new Point(39, 25);
            lbl_alumnos.Name = "lbl_alumnos";
            lbl_alumnos.Size = new Size(108, 32);
            lbl_alumnos.TabIndex = 1;
            lbl_alumnos.Text = "Alumnos";
            // 
            // lbl_informacion
            // 
            lbl_informacion.AutoSize = true;
            lbl_informacion.Font = new Font("Segoe UI", 18F);
            lbl_informacion.Location = new Point(397, 25);
            lbl_informacion.Name = "lbl_informacion";
            lbl_informacion.Size = new Size(142, 32);
            lbl_informacion.TabIndex = 1;
            lbl_informacion.Text = "Informacion";
            // 
            // dtg_informacion
            // 
            dtg_informacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_informacion.Location = new Point(176, 60);
            dtg_informacion.Name = "dtg_informacion";
            dtg_informacion.Size = new Size(596, 334);
            dtg_informacion.TabIndex = 6;
            dtg_informacion.CellContentClick += dtg_informacion_CellContentClick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dtg_informacion);
            Controls.Add(lst_estudiantes);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_evaluar);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_informacion);
            Controls.Add(lbl_alumnos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "Notas de estudiantes";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_informacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_agregar;
        private Button btn_evaluar;
        private Button btn_mostrar;
        private ListBox lst_estudiantes;
        private Label lbl_alumnos;
        private Label lbl_informacion;
        private DataGridView dtg_informacion;
    }
}
