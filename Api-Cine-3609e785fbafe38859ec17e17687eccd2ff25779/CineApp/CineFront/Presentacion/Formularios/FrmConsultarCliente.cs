using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            CargarBarriosAsync();
        }

        private async void CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "Descripcion";
            cboBarrio.ValueMember = "BarrioNro";
            cboBarrio.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            cargarClientesFiltrados(idBarrio);
        }

        private async void cargarClientesFiltrados(int idBarrio)
        {
            string url = $"https://localhost:7149/clientesFiltrados?idBarrio={idBarrio}";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

            dgvClientes.Rows.Clear();
            if (lst != null)
            {
                foreach (Cliente c in lst)
                {
                    dgvClientes.Rows.Add(new object[]
                    {
                    c.CodCliente,
                    c.Nombre,
                    c.Correo,
                    c.CodBarrio,
                    c.NroTel
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de Clientes para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int nro = int.Parse(dgvClientes.CurrentRow.Cells["Column1"].Value.ToString());
            new FrmModificacionCliente(nro).ShowDialog();
            dgvClientes.Rows.Clear();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvClientes.CurrentRow.Cells["Column1"].Value.ToString());

            await EliminarClienteAsync(nro);
        }

        private async Task EliminarClienteAsync(int nro)
        {
            if (MessageBox.Show("Seguro que desea quitar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvClientes.CurrentRow != null)
                {
                    string url = "https://localhost:7149/DeleteCliente?idCliente=" + nro;

                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("El cliente se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                        cargarClientesFiltrados(idBarrio);
                    }
                    else
                    {
                        MessageBox.Show("El cliente NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
