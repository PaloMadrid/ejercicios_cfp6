using Biblioteca_Estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEstudiantes
{
    public partial class formCrear : Form
    {
        private Estudiante nuevoAlumno;

        public formCrear()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtbx_apellido.Text) && !string.IsNullOrEmpty(txtbx_legajo.Text) && !string.IsNullOrEmpty(txtbx_nombre.Text))
            {
                nuevoAlumno = new Estudiante(
                txtbx_apellido.Text, txtbx_legajo.Text, txtbx_nombre.Text
                );
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Todos los campos son obligatorios","",MessageBoxButtons.OK);
            }

            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

         public Estudiante MiAlumno
        {
            get 
            { 
                return nuevoAlumno; 
            }
        }
    }
}
