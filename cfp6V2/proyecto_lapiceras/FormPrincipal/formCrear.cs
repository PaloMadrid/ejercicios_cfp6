using Mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class formCrear : Form
    {
        Lapicera nuevaLapicera;
        //List<Lapicera> nuevaLapicera;
        public formCrear()
        {
            InitializeComponent();
        }

        private void grbx_color_Enter(object sender, EventArgs e)
        {

        }

        private void formCrear_Load(object sender, EventArgs e)
        {

            this.cbx_color.DataSource = Lapicera.ListaDeColores();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
           
            string marca = "";
            int precio;//= int.Parse(tbx_precio.Text);
            Color color = Color.FromName(cbx_color.Text);
            bool banderaNum= int.TryParse(tbx_precio.Text, out precio);

            foreach (RadioButton rd in grbx_marca.Controls)
            {
                if (rd.Checked == true)
                {
                   
                    marca = rd.Text;

                    break;

                }
            }

            
            if ( banderaNum==false || precio<1 )
            {
                
                MessageBox.Show("No es un precio valido");
            } else if (!marca.Any())
            {
                MessageBox.Show("Seleccione una marca");
            //}else if (color  ())
            //{

            }
            else
            {
                nuevaLapicera = new Lapicera(
                color, precio, marca
                );
                this.DialogResult = DialogResult.OK;
            }

            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        public Lapicera laLapicera
        {

            get
            {

                return nuevaLapicera;
            }
        }
    }
}
