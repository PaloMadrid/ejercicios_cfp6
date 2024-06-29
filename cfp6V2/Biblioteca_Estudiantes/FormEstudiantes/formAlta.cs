using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Estudiantes;
using Biblioteca_Funciones;
using Ingresantes;

namespace FormEstudiantes
{
    public partial class formAlta : Form
    {
        //crear biblioteca ingresante y declarar un objeto de tipo ingresante

        private Ingresante nuevoIngresante;
        private List<string> paises;

        public formAlta()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)num_edad.Value;
            string genero = "";
            string pais = lst_paises.Text;
            List<string> cursos = new List<string>();

            bool banderaRB = false;
            bool banderaCB = false;



            //metodos
            foreach (RadioButton rd in gpb_generos.Controls)
            {
                if (rd.Checked == true)
                {
                    banderaRB = true;
                    genero = rd.Text;
                    break;

                }
            }


            foreach (CheckBox cb in gpb_cursos.Controls)
            {
                if (cb.Checked == true)
                {
                    banderaCB = true;
                    cursos.Add(cb.Text);
                }
            }

            if (banderaCB && banderaRB && !string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_nombre.Text))
            {
                nuevoIngresante = new Ingresante(
                    nombre, apellido, edad, genero, pais, cursos
                    );
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "", MessageBoxButtons.OK);
            }

        }
        public Ingresante miIngresante
        {
            get
            {
                return nuevoIngresante;
            }
        }

        private void formAlta_Load(object sender, EventArgs e)
        {
            //se declara la lista en el main de la clase form y luego se instancia recien en el load
            
            this.paises = new List<string>();
            this.paises = Ingresante.ListaDePaises();

            this.lst_paises.DataSource = paises;
        }
    }
}
