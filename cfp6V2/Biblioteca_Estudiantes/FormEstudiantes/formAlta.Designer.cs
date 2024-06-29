namespace FormEstudiantes
{
    partial class formAlta
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
            gpb_datos = new GroupBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            num_edad = new NumericUpDown();
            gpb_cursos = new GroupBox();
            chk_node = new CheckBox();
            chk_html = new CheckBox();
            chk_csharp = new CheckBox();
            chk_pyton = new CheckBox();
            chk_java = new CheckBox();
            gpb_generos = new GroupBox();
            rb_noBinario = new RadioButton();
            rb_femenino = new RadioButton();
            rb_masculino = new RadioButton();
            lst_paises = new ListBox();
            btn_agregar = new Button();
            btn_cancelar = new Button();
            label4 = new Label();
            gpb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            gpb_cursos.SuspendLayout();
            gpb_generos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_datos
            // 
            gpb_datos.Controls.Add(txt_nombre);
            gpb_datos.Controls.Add(txt_apellido);
            gpb_datos.Controls.Add(label3);
            gpb_datos.Controls.Add(label2);
            gpb_datos.Controls.Add(label1);
            gpb_datos.Controls.Add(num_edad);
            gpb_datos.Location = new Point(12, 29);
            gpb_datos.Name = "gpb_datos";
            gpb_datos.Size = new Size(340, 156);
            gpb_datos.TabIndex = 0;
            gpb_datos.TabStop = false;
            gpb_datos.Text = "Datos del ingresante";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(129, 35);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(189, 23);
            txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(129, 69);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(189, 23);
            txt_apellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 108);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(129, 106);
            num_edad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(189, 23);
            num_edad.TabIndex = 3;
            num_edad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gpb_cursos
            // 
            gpb_cursos.Controls.Add(chk_node);
            gpb_cursos.Controls.Add(chk_html);
            gpb_cursos.Controls.Add(chk_csharp);
            gpb_cursos.Controls.Add(chk_pyton);
            gpb_cursos.Controls.Add(chk_java);
            gpb_cursos.Location = new Point(432, 179);
            gpb_cursos.Name = "gpb_cursos";
            gpb_cursos.Size = new Size(298, 176);
            gpb_cursos.TabIndex = 6;
            gpb_cursos.TabStop = false;
            gpb_cursos.Text = "Cursos";
            // 
            // chk_node
            // 
            chk_node.AutoSize = true;
            chk_node.Location = new Point(13, 130);
            chk_node.Name = "chk_node";
            chk_node.Size = new Size(68, 19);
            chk_node.TabIndex = 4;
            chk_node.Text = "Node JS";
            chk_node.UseVisualStyleBackColor = true;
            // 
            // chk_html
            // 
            chk_html.AutoSize = true;
            chk_html.Location = new Point(13, 105);
            chk_html.Name = "chk_html";
            chk_html.Size = new Size(58, 19);
            chk_html.TabIndex = 3;
            chk_html.Text = "HTML";
            chk_html.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            chk_csharp.AutoSize = true;
            chk_csharp.Location = new Point(13, 30);
            chk_csharp.Name = "chk_csharp";
            chk_csharp.Size = new Size(41, 19);
            chk_csharp.TabIndex = 0;
            chk_csharp.Text = "C#";
            chk_csharp.UseVisualStyleBackColor = true;
            // 
            // chk_pyton
            // 
            chk_pyton.AutoSize = true;
            chk_pyton.Location = new Point(13, 80);
            chk_pyton.Name = "chk_pyton";
            chk_pyton.Size = new Size(64, 19);
            chk_pyton.TabIndex = 2;
            chk_pyton.Text = "Python";
            chk_pyton.UseVisualStyleBackColor = true;
            // 
            // chk_java
            // 
            chk_java.AutoSize = true;
            chk_java.Location = new Point(13, 55);
            chk_java.Name = "chk_java";
            chk_java.Size = new Size(48, 19);
            chk_java.TabIndex = 1;
            chk_java.Text = "Java";
            chk_java.UseVisualStyleBackColor = true;
            // 
            // gpb_generos
            // 
            gpb_generos.Controls.Add(rb_noBinario);
            gpb_generos.Controls.Add(rb_femenino);
            gpb_generos.Controls.Add(rb_masculino);
            gpb_generos.Location = new Point(432, 12);
            gpb_generos.Name = "gpb_generos";
            gpb_generos.Size = new Size(298, 161);
            gpb_generos.TabIndex = 5;
            gpb_generos.TabStop = false;
            gpb_generos.Text = "Genero";
            // 
            // rb_noBinario
            // 
            rb_noBinario.AutoSize = true;
            rb_noBinario.Location = new Point(13, 94);
            rb_noBinario.Name = "rb_noBinario";
            rb_noBinario.Size = new Size(81, 19);
            rb_noBinario.TabIndex = 6;
            rb_noBinario.TabStop = true;
            rb_noBinario.Text = "No binario";
            rb_noBinario.UseVisualStyleBackColor = false;
            // 
            // rb_femenino
            // 
            rb_femenino.AutoSize = true;
            rb_femenino.Location = new Point(13, 62);
            rb_femenino.Name = "rb_femenino";
            rb_femenino.Size = new Size(78, 19);
            rb_femenino.TabIndex = 5;
            rb_femenino.TabStop = true;
            rb_femenino.Text = "Femenino";
            rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            rb_masculino.AutoSize = true;
            rb_masculino.Location = new Point(13, 32);
            rb_masculino.Name = "rb_masculino";
            rb_masculino.Size = new Size(80, 19);
            rb_masculino.TabIndex = 4;
            rb_masculino.TabStop = true;
            rb_masculino.Text = "Masculino";
            rb_masculino.UseVisualStyleBackColor = true;
            // 
            // lst_paises
            // 
            lst_paises.FormattingEnabled = true;
            lst_paises.ItemHeight = 15;
            lst_paises.Location = new Point(34, 234);
            lst_paises.Name = "lst_paises";
            lst_paises.Size = new Size(318, 139);
            lst_paises.TabIndex = 4;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(375, 413);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(196, 413);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 209);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 4;
            label4.Text = "Pais";
            // 
            // formAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(label4);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(lst_paises);
            Controls.Add(gpb_cursos);
            Controls.Add(gpb_generos);
            Controls.Add(gpb_datos);
            Name = "formAlta";
            Text = "Form1";
            Load += formAlta_Load;
            gpb_datos.ResumeLayout(false);
            gpb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            gpb_cursos.ResumeLayout(false);
            gpb_cursos.PerformLayout();
            gpb_generos.ResumeLayout(false);
            gpb_generos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_datos;
        private GroupBox gpb_cursos;
        private GroupBox gpb_generos;
        private CheckBox chk_java;
        private CheckBox chk_csharp;
        private ListBox lst_paises;
        private Button btn_agregar;
        private Button btn_cancelar;
        private RadioButton rb_masculino;
        private RadioButton rb_femenino;
        private RadioButton rb_noBinario;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown num_edad;
        private CheckBox chk_node;
        private CheckBox chk_html;
        private CheckBox chk_pyton;
        private Label label4;
    }
}