using Biblioteca_Estudiantes;
namespace FormEstudiantes
{
    public partial class FormPrincipal : Form
    {
        private List<Estudiante> misEstudiantes;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.misEstudiantes = new List<Estudiante>();
            this.misEstudiantes = Estudiante.ListaDeAlumnos();

            this.lst_estudiantes.DataSource = misEstudiantes;
        }

        private void dtg_informacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            CargarDGV(); 
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            formCrear formAlta = new formCrear();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                misEstudiantes.Add(formAlta.MiAlumno);
                
            }
        }

        private void CargarListaAlumnos()
        {
            lst_estudiantes.DataSource = null;
            lst_estudiantes.DataSource = misEstudiantes;
        } 
        private void CargarDGV()
        {
            dtg_informacion.DataSource=null;
            dtg_informacion.DataSource=misEstudiantes;
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            foreach(Estudiante item in misEstudiantes)
            {
                 item.NotaPrimerParcial=rdn.Next(1,10);
                item.NotaSegundoParcial= rdn.Next(1, 10);
            }
        }

    }
}
