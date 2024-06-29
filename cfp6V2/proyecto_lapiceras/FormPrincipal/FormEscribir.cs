using mis_clases;
using Mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class FormEscribir : Form
    {
        private List<Lapicera> misLapiceras = new List<Lapicera>();
        private int seleccionada ;
        public FormEscribir()
        {
            InitializeComponent();
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            string textoIngresado = txbx_texto.Text;
            //Lapicera.lst_lapiceras.SelectedItems;
            //bool bandera = ;
                //Lapicera.Escribir(textoIngresado);
                seleccionada = (lst_lapiceras.SelectedItems);

            foreach(Lapicera lapicera in misLapiceras)
            {
                if()
            }
        }

        private void FormEscribir_Load(object sender, EventArgs e)
        {
            this.misLapiceras = Lapicera.ListaDeLapiceras();
            this.lst_lapiceras.DataSource = this.misLapiceras;
        }
    }
}
