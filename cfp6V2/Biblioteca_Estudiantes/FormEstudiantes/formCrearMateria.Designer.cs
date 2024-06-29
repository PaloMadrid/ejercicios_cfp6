namespace FormEstudiantes
{
    partial class formCrearMateria
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
            label3 = new Label();
            txt_nombre = new TextBox();
            txt_docente = new TextBox();
            txt_duracion = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Docente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 136);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Duracion";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(43, 45);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 3;
            // 
            // txt_docente
            // 
            txt_docente.Location = new Point(43, 98);
            txt_docente.Name = "txt_docente";
            txt_docente.Size = new Size(100, 23);
            txt_docente.TabIndex = 4;
            // 
            // txt_duracion
            // 
            txt_duracion.Location = new Point(43, 154);
            txt_duracion.Name = "txt_duracion";
            txt_duracion.Size = new Size(100, 23);
            txt_duracion.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(6, 206);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 6;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(105, 206);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // formCrearMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 245);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txt_duracion);
            Controls.Add(txt_docente);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formCrearMateria";
            Text = "Agregar materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nombre;
        private TextBox txt_docente;
        private TextBox txt_duracion;
        private Button btn_aceptar;
        private Button btn_cancelar;
    }
}