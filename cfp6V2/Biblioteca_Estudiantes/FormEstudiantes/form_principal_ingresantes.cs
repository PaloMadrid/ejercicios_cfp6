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
using Ingresantes;

namespace FormEstudiantes
{


    public partial class form_principal_ingresantes : Form
    {
        private List<Ingresante> misIngresantes;
        public form_principal_ingresantes()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //metodo
            dtg_informacion.DataSource = misIngresantes;
            dtg_informacion.DataSource = null;
        }

        private void form_principal_ingresantes_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            formAlta formularioAlta = new formAlta();

            formularioAlta.ShowDialog();

            if(formularioAlta.DialogResult == DialogResult.OK)
            {
                misIngresantes.Add(formularioAlta.miIngresante);
            }
        }

        private void dtg_informacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
