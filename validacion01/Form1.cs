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

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
            {
                MessageBox.Show("Datos Ingresados");
            }
        }

        private bool ValidarCampos()
        {
            bool ok = false;
            if (txtnombre.Text == "")
            {
                ok = true;
                errorProvider1.SetError(txtnombre, "Ingresar Nombre");
            }

            if (txtapellido.Text == "")
            {
                ok = true;
                errorProvider1.SetError(txtapellido, "Ingresar Apellido");
            }

            if (txtemail.Text == "")
            {
                ok = true;
                errorProvider1.SetError(txtemail, "Ingresar Email");
            }

            if (txtdireccion.Text == "")
            {
                ok = true;
                errorProvider1.SetError(txtdireccion, "Ingresar Direccion");
            }

            return ok;
        }
        private void borrarmensajeerror()
        {
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtapellido, "");
            errorProvider1.SetError(txtemail, "");
            errorProvider1.SetError(txtdireccion, "");


        }
    }
}