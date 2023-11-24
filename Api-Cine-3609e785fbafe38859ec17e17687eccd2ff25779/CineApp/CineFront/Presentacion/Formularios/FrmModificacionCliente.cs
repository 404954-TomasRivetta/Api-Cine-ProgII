using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmModificacionCliente : Form
    {

        private int idCliente;

        public FrmModificacionCliente(int idCliente)
        {
            InitializeComponent();

            this.idCliente = idCliente;
        }

        private async void FrmModificacionCliente_Load(object sender, EventArgs e)
        {
            CargarBarriosAsync();
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarDatosAntiguosAsync();

        }

        private async void CargarDatosAntiguosAsync()
        {
            string url = string.Format("https://localhost:7149/clientes/{0}", idCliente);
            var result = await ClienteSingleton.GetInstance().GetAsync(url);

            var cliente = JsonConvert.DeserializeObject<Cliente>(result);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtNroTel.Text = Convert.ToString(cliente.NroTel);
                txtCorreo.Text = cliente.Correo;
                cboBarrios.SelectedIndex = cliente.CodBarrio;
                txtCalle.Text = cliente.Calle;
                txtAltura.Text = Convert.ToString(cliente.CalleNro);
                txtDni.Text = Convert.ToString(cliente.Dni);
            }
            else
            {
                MessageBox.Show("No se pudo recuperar información del cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.DataSource = lst;
            cboBarrios.DisplayMember = "Descripcion";
            cboBarrios.ValueMember = "BarrioNro";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ModificarClienteAsync();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtNroTel.Text) || !int.TryParse(txtNroTel.Text, out _))
            {
                MessageBox.Show("Ingrese un numero de telefono valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Ingrese una calle valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtAltura.Text) || !int.TryParse(txtAltura.Text, out _))
            {
                MessageBox.Show("Ingrese una altura valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text) || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Ingrese un DNI valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private async void ModificarClienteAsync()
        {
            try
            {
                Cliente c = new Cliente();
                c.CodCliente = idCliente;
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.NroTel = Convert.ToInt32(txtNroTel.Text);
                c.Correo = txtCorreo.Text;
                c.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                c.Calle = txtCalle.Text;
                c.CalleNro = Convert.ToInt32(txtAltura.Text);
                c.Dni = Convert.ToInt32(txtDni.Text);


                string bodyContent = JsonConvert.SerializeObject(c);
                string url = "https://localhost:7149/api/Cliente/clientes_modificar/" + idCliente;

                var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);
                if (result.Equals("true"))
                {
                    MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }

        }

    }
}
