using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmAltaComprobante : Form
    {
        private Comprobante nuevo;
        public FrmAltaComprobante()
        {
            InitializeComponent();
            nuevo = new Comprobante();
        }

        private async void FrmAltaComprobante_Load_1(object sender, EventArgs e)
        {
            await CargarClientesAsync();
            await CargarFormasPagoAsync();
            await CargarEmpleadosAsync();
            await CargarPeliculasAsync();
            await ProximoComprobante();
        }

        private async Task ProximoComprobante()
        {

            string url = "https://localhost:7149/proxComprobante";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<int>(bodyJson);
            txtProximoComprobante.Text = txtProximoComprobante.Text + lst;
        }

        private async Task CargarPeliculasAsync()
        {
            string url = "https://localhost:7149/AllPeliculas";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Pelicula>>(bodyJson);
            //cargar combo
            cboPeliculas.DataSource = lst;
            cboPeliculas.ValueMember = "IdPelicula";
            cboPeliculas.DisplayMember = "Descripcion";
        }

        private async Task CargarFormasPagoAsync()
        {
            string url = "https://localhost:7149/formas_pago";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoFormaPago>>(bodyJson);
            //cargar combo
            cboFormasP.DataSource = lst;
            cboFormasP.ValueMember = "id";
            cboFormasP.DisplayMember = "Descripcion";
        }

        private async Task CargarEmpleadosAsync()
        {
            string url = "https://localhost:7149/empleados";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Empleado>>(bodyJson);
            //cargar combo
            cboEmpleado.DataSource = lst;
            cboEmpleado.ValueMember = "CodEmpleado";
            cboEmpleado.DisplayMember = "Apellido";
        }

        private async Task CargarClientesAsync()
        {
            string url = "https://localhost:7149/clientes";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(bodyJson);
            //cargar combo
            cboClientes.DataSource = lst;
            cboClientes.ValueMember = "CodCliente";
            cboClientes.DisplayMember = "Apellido";
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await GuardarComprobanteAsync();
        }

        private async Task GuardarComprobanteAsync()
        {
            TipoFormaPago t = (TipoFormaPago)cboFormasP.SelectedItem;
            Cliente c = (Cliente)cboClientes.SelectedItem;
            Empleado e = (Empleado)cboEmpleado.SelectedItem;
            nuevo.IdCliente = c.CodCliente;
            nuevo.IdForma_pago = t.id;
            nuevo.IdEmpleado = e.CodEmpleado;
            nuevo.CantEntradas = Convert.ToInt32(cantEntradas.Value);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7149/api/Comprobante";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)    
            {
                MessageBox.Show("Presupuesto registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la operacion?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.CurrentCell.ColumnIndex == 5)
            {
                //nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvTickets.Rows.Remove(dgvTickets.CurrentRow);
                //presupuesto.quitarDetalle();


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            int butacaFila = Convert.ToInt32(txtFila.Text);
            int butacaColumna = Convert.ToInt32(txtColumna.Text);
            int preUnitario = Convert.ToInt32(txtPreUnitario.Text);
            Pelicula p = (Pelicula)cboPeliculas.SelectedItem;
            Funciones f = (Funciones)cboFechaHora.SelectedItem;


            dgvTickets.Rows.Add(new object[] { butacaFila, butacaColumna, preUnitario, p.Descripcion, f.FechaHora, "Quitar ඞ" });

            
            Tickets t = new Tickets();
            t.PreUnitario = preUnitario;
            

        }
        private bool ValidarDatos()
        {
            if (!string.IsNullOrEmpty(txtFila.Text) || int.TryParse(txtFila.Text, out _))
            {
                MessageBox.Show("Ingrese una fila valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtColumna.Text) || int.TryParse(txtColumna.Text, out _))
            {
                MessageBox.Show("Ingrese una columna valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtPreUnitario.Text) || int.TryParse(txtPreUnitario.Text, out _))
            {
                MessageBox.Show("Ingrese un precio valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una pelicula valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboFechaHora.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una fecha y hora valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void cboFormasP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelicula p = (Pelicula)cboPeliculas.SelectedItem;
            await CargarFechaHoraPeliculaAsync(p.IdPelicula);

        }

        private async Task CargarFechaHoraPeliculaAsync(int nro)
        {
            string url = "https://localhost:7149/Funciones?nro=" + nro;
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funciones>>(bodyJson);
            //cargar combo
            cboFechaHora.DataSource = lst;
            cboFechaHora.ValueMember = "IdFuncion";
            cboFechaHora.DisplayMember = "FechaHora";
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
