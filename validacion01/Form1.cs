namespace validacion01
{
    public partial class frmvalidacion : Form
    {
        public frmvalidacion()
        {
            InitializeComponent();
        }

        private void frmvalidacion_Load(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtdireccion.Enabled = false;
            txtemail.Enabled = false;

            txtnombre.BackColor = Color.BlanchedAlmond;
            txtapellido.BackColor = Color.BlanchedAlmond;
            txtdireccion.BackColor = Color.BlanchedAlmond;
            txtemail.BackColor = Color.BlanchedAlmond;
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;

            txtnombre.BackColor = Color.White;
            txtapellido.BackColor = Color.White;
            txtdireccion.BackColor = Color.White;
            txtemail.BackColor = Color.White;
        }
    }
}