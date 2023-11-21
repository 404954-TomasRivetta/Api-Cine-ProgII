using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmModificacionCliente : Form
    {

        private int id_cliente;

        public FrmModificacionCliente(int idCliente)
        {
            InitializeComponent();
            id_cliente = idCliente;
        }

        private async void FrmModificacionCliente_Load(object sender, EventArgs e)
        {
            await CargarBarriosAsync();
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarDatosAntiguosAsync();
        }

        private async void CargarDatosAntiguosAsync()
        {
            string url = string.Format("https://localhost:7149/clientes/{0}",id_cliente);
            var result = await ClienteSingleton.GetInstance().GetAsync(url);

            var cliente = JsonConvert.DeserializeObject<Cliente>(result);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                cboBarrios.SelectedValue = cliente.CodBarrio;
                txtApellido.Text = cliente.Apellido;
                txtCalle.Text = cliente.Calle;
                txtNroTel.Text = Convert.ToInt32(cliente.NroTel).ToString();
                txtAltura.Text = Convert.ToInt32(cliente.CalleNro).ToString();
                txtCorreo.Text = cliente.Correo;
                txtDni.Text = Convert.ToInt32(cliente.Dni).ToString();
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
            if (MessageBox.Show("Seguro desea cancelar la operacion?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                await ModificarClienteAsync();
            }
        }

        private bool ValidarDatos()
        {
            if (!int.TryParse(txtAltura.Text, out _) || string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Ingrese una altura valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtDni.Text, out _) || string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Ingrese un dni valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtNroTel.Text, out _) || string.IsNullOrEmpty(txtNroTel.Text))
            {
                MessageBox.Show("Ingrese un numero de telefono valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task ModificarClienteAsync()
        {
            try
            {
                Cliente c = new Cliente();
                c.CodCliente = id_cliente;
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.NroTel = Convert.ToInt32(txtNroTel.Text);
                c.Correo = txtCorreo.Text;
                c.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                c.Calle = txtCalle.Text;
                c.CalleNro = Convert.ToInt32(txtAltura.Text);
                c.Dni = Convert.ToInt32(txtDni.Text);


                string bodyContent = JsonConvert.SerializeObject(c);
                string url = "https://localhost:7149/clientes_modificar/" + c.CodCliente.ToString();

                var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);
                if (result.Equals("true"))
                {
                    MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }

        }

    }
}
