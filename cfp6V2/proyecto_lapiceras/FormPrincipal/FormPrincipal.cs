using formularios;
using Mis_clases;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        private List<Lapicera> misLapiceras = new List<Lapicera>();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.misLapiceras = Lapicera.ListaDeLapiceras();
            CargarDGV();

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            CargarDGV();


        }

        private void CargarDGV()
        {

            this.dtg_lapiceras.DataSource = null;
            this.dtg_lapiceras.DataSource = this.misLapiceras;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            formCrear formAlta = new formCrear();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                Lapicera dato = formAlta.laLapicera;
                misLapiceras.Add(dato);

            }
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            FormEscribir formRedactar = new FormEscribir();




        }
    }
}
