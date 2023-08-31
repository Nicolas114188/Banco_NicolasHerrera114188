using BancoApp1_3.Presentacion;

namespace BancoApp1_3
{
    public partial class BancoApp : Form
    {
        public BancoApp()
        {
            InitializeComponent();
        }

        private void BancoApp_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevo=new NuevoCliente();
            nuevo.ShowDialog();
        }
    }
}