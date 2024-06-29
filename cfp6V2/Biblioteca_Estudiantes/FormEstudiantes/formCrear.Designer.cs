namespace FormEstudiantes
{
    partial class formCrear
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
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_legajo = new Label();
            txtbx_nombre = new TextBox();
            txtbx_apellido = new TextBox();
            txtbx_legajo = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(38, 142);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(38, 87);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 6;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(38, 32);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 7;
            lbl_legajo.Text = "Legajo";
            // 
            // txtbx_nombre
            // 
            txtbx_nombre.Location = new Point(38, 157);
            txtbx_nombre.Name = "txtbx_nombre";
            txtbx_nombre.Size = new Size(100, 23);
            txtbx_nombre.TabIndex = 3;
            // 
            // txtbx_apellido
            // 
            txtbx_apellido.Location = new Point(38, 105);
            txtbx_apellido.Name = "txtbx_apellido";
            txtbx_apellido.Size = new Size(100, 23);
            txtbx_apellido.TabIndex = 2;
            // 
            // txtbx_legajo
            // 
            txtbx_legajo.Location = new Point(38, 51);
            txtbx_legajo.Name = "txtbx_legajo";
            txtbx_legajo.Size = new Size(100, 23);
            txtbx_legajo.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(8, 213);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(68, 22);
            btn_aceptar.TabIndex = 4;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(96, 213);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(68, 22);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // formCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 249);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_legajo);
            Controls.Add(txtbx_nombre);
            Controls.Add(txtbx_apellido);
            Controls.Add(txtbx_legajo);
            Name = "formCrear";
            Text = "Agregar estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_legajo;
        private TextBox txtbx_nombre;
        private TextBox txtbx_apellido;
        private TextBox txtbx_legajo;
        private Button btn_aceptar;
        private Button btn_cancelar;
    }
}