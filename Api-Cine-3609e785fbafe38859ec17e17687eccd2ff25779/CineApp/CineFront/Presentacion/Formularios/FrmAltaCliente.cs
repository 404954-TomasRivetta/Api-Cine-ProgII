using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmAltaCliente : Form
    {
        private Cliente nuevo;
        public FrmAltaCliente()
        {
            InitializeComponent();
            nuevo = new Cliente();
        }

        private void FrmAltaCliente_Load_1(object sender, EventArgs e)
        {
            CargarBarriosAsync();
        }
        private async void CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.DataSource = lst;
            cboBarrios.DisplayMember = "Descripcion";
            cboBarrios.ValueMember = "BarrioNro";
        }
        private bool ValidarDatos()
        {
            if (!int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Ingrese un DNI valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!int.TryParse(txtAltura.Text, out _))
            {
                MessageBox.Show("Ingrese una altura valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private async Task GuardarClienteAsync()
        {
            ValidarDatos();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.NroTel = (int)Convert.ToInt64(txtNroTel.Text);
            nuevo.Correo = txtCorreo.Text;
            nuevo.CodBarrio = (int)Convert.ToInt64(cboBarrios.SelectedValue);
            nuevo.Calle = txtCalle.Text;
            nuevo.CalleNro = Convert.ToInt32(txtAltura.Text);
            nuevo.Dni = (int)Convert.ToInt64(txtDni.Text);

            //nuevo.NombreBarrio = " ";
            //nuevo.NombrePelicula = " ";
            //nuevo.NombreCompleto = " ";

            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7149/cliente";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await GuardarClienteAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la operacion?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
