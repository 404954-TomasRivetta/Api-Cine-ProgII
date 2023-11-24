using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmAltaComprobante : Form
    {
        private Comprobante nuevo;

        public FrmAltaComprobante()
        {
            InitializeComponent();
            nuevo = new Comprobante();
            ConfigurarManejadoresDeEventos();
            AsignarTags();
            //AsignarIdABotones();
        }

        private async void FrmAltaComprobante_Load_1(object sender, EventArgs e)
        {
            cantEntradas.Value = 1;
            await CargarClientesAsync();
            await CargarFormasPagoAsync();
            await CargarEmpleadosAsync();
            await CargarPeliculasAsync();
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

            await GrabarComprobanteAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la operacion?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                //int valor = Convert.ToInt32(dgvTickets.Columns["ColIdButaca"].);
                int valor = Convert.ToInt32(dgvTickets.CurrentRow.Cells["ColIdButaca"].Value);

                var botonesOcupados = this.Controls.OfType<Button>().FirstOrDefault(b => Convert.ToInt32(b.Tag) == valor);
                Button b = (Button)botonesOcupados;

                b.BackColor = Color.Lime;
                b.Enabled = true;

                nuevo.QuitarTicket(dgvTickets.CurrentRow.Index);
                dgvTickets.Rows.RemoveAt(dgvTickets.CurrentRow.Index);

            }
            if (dgvTickets.Rows.Count == 0)
            {
                cboPeliculas.Enabled = true;
                cboFechaHora.Enabled = true;
            }
        }


        private bool ValidarDatos()
        {

            if (string.IsNullOrEmpty(txtPreUnitario.Text) || !int.TryParse(txtPreUnitario.Text, out _))
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
            if (cantEntradas.Value < dgvTickets.Rows.Count)
            {
                MessageBox.Show("No puede agregar mas entradas que la cantidad que eligió!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cantEntradas.Value > dgvTickets.Rows.Count)
            {
                MessageBox.Show("Faltan añadir entradas!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void ConfigurarManejadoresDeEventos()
        {
            for (int i = 1; i <= 44; i++)
            {
                Button boton = Controls.Find("button" + i, true).FirstOrDefault() as Button;

                if (boton != null)
                {
                    AsignarManejadorDeEventosAlBoton(boton);
                }
            }
        }
        private void AsignarManejadorDeEventosAlBoton(Button boton)
        {
            if (boton != null)
            {
                boton.Click += new EventHandler(Boton_Click);
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            if (boton != null)
            {
                if (boton.BackColor == Color.Lime)
                {
                    boton.BackColor = Color.Orange;
                }
                else
                {
                    boton.BackColor = Color.Lime;
                }

            }
        }

        private int IdButaca()
        {
            // Encuentra el primer botón con color rojo
            Button botonSeleccionado = this.Controls.OfType<Button>().FirstOrDefault(b => b.BackColor == Color.Orange);

            if (botonSeleccionado != null && botonSeleccionado.Tag != null)
            {
                // Si el botón tiene un Tag válido, devuelve su ID
                return Convert.ToInt32(botonSeleccionado.Tag);
            }

            // Si no se encontró un botón rojo válido, devuelve 0 o maneja el caso según sea necesario
            return 0;
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidarDatos())
            {
                await GrabarComprobanteAsync();

            }

        }
        private async Task GrabarComprobanteAsync()
        {
            //validar datos..
            nuevo.IdCliente = Convert.ToInt32(cboClientes.SelectedValue);
            nuevo.IdForma_pago = 1;
            nuevo.IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            nuevo.CantEntradas = Convert.ToInt32(cantEntradas.Value);
            nuevo.IdFuncion = Convert.ToInt32(cboFechaHora.SelectedValue);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7149/nuevoComprobante";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Comprobante registrado!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el comprobante!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            cboFechaHora.Enabled = false;
            cboPeliculas.Enabled = false;
            if (ControlButaca() > 1)
            {
                MessageBox.Show("Debe seleccionar solo una butaca!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtPreUnitario.Text) || !double.TryParse(txtPreUnitario.Text, out _))
            {
                MessageBox.Show("Ingrese un precio valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idbut = IdButaca();
            Tickets tic = new Tickets();
            tic.PreUnitario = Convert.ToDouble(txtPreUnitario.Text);
            tic.IdButaca = idbut;
            Pelicula peli = (Pelicula)cboPeliculas.SelectedItem;
            nuevo.AgregarTicket(tic);
            dgvTickets.Rows.Add(new object[] { idbut, tic.PreUnitario, peli.Descripcion, cboFechaHora.Text, "Quitar" });

            var botonesNaranjas = this.Controls.OfType<Button>().Where(b => b.BackColor == Color.Orange);
            foreach (Button b in botonesNaranjas)
            {
                b.BackColor = Color.Red;
                b.Enabled = false;
            }

        }
        private async void cboPeliculas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Pelicula p = (Pelicula)cboPeliculas.SelectedItem;
            await CargarFechaHoraPeliculaAsync(p.IdPelicula);
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private async void cboFechaHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            BloquearButacasOcupadas(true);

            var botonesRojos = this.Controls.OfType<Button>().Where(b => b.BackColor == Color.Red);

            foreach (var b in botonesRojos)
            {
                b.BackColor = Color.Lime;
            }

            Funciones f = (Funciones)cboFechaHora.SelectedItem;
            await CargarButacasPeliculaAsync(f.IdFuncion);

            BloquearButacasOcupadas(false);
        }
        private int ControlButaca()
        {
            int cant = 0;
            var botonesNaranjas = this.Controls.OfType<Button>().Where(b => b.BackColor == Color.Orange);
            foreach (Button b in botonesNaranjas)
            {
                cant++;
            }
            return cant;
        }
        private void BloquearButacasOcupadas(bool bandera)
        {
            var botonesRojos = this.Controls.OfType<Button>().Where(b => b.BackColor == Color.Red);

            foreach (var b in botonesRojos)
            {
                b.Enabled = bandera;
            }
        }

        private async Task CargarButacasPeliculaAsync(int idFuncion)
        {
            string url = "https://localhost:7149/Butacas?nro=" + idFuncion;
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Butaca>>(bodyJson);

            if (lst != null)
            {
                List<Butaca> lButacas = new List<Butaca>();
                //cargar lista
                for (int i = 0; i < lst.Count; i++)
                {
                    Butaca b = new Butaca();

                    b.IdButaca = lst[i].IdButaca;
                    b.Fila = lst[i].Fila;
                    b.Columna = lst[i].Columna;
                    lButacas.Add(b);
                }

                foreach (Butaca b in lButacas)
                {
                    switch (b.IdButaca)
                    {
                        case 31:
                            button1.BackColor = Color.Red;
                            break;
                        case 32:
                            button2.BackColor = Color.Red;
                            break;
                        case 33:
                            button3.BackColor = Color.Red;
                            break;
                        case 34:
                            button4.BackColor = Color.Red;
                            break;
                        case 35:
                            button5.BackColor = Color.Red;
                            break;
                        case 36:
                            button6.BackColor = Color.Red;
                            break;
                        case 37:
                            button7.BackColor = Color.Red;
                            break;
                        case 38:
                            button8.BackColor = Color.Red;
                            break;
                        case 39:
                            button9.BackColor = Color.Red;
                            break;
                        case 40:
                            button10.BackColor = Color.Red;
                            break;
                        case 41:
                            button11.BackColor = Color.Red;
                            break;
                        case 42:
                            button12.BackColor = Color.Red;
                            break;
                        case 43:
                            button13.BackColor = Color.Red;
                            break;
                        case 44:
                            button14.BackColor = Color.Red;
                            break;
                        case 45:
                            button15.BackColor = Color.Red;
                            break;
                        case 46:
                            button16.BackColor = Color.Red;
                            break;
                        case 47:
                            button17.BackColor = Color.Red;
                            break;
                        case 48:
                            button18.BackColor = Color.Red;
                            break;
                        case 49:
                            button19.BackColor = Color.Red;
                            break;
                        case 50:
                            button20.BackColor = Color.Red;
                            break;
                        case 51:
                            button21.BackColor = Color.Red;
                            break;
                        case 52:
                            button22.BackColor = Color.Red;
                            break;
                        case 53:
                            button23.BackColor = Color.Red;
                            break;
                        case 54:
                            button24.BackColor = Color.Red;
                            break;
                        case 55:
                            button25.BackColor = Color.Red;
                            break;
                        case 56:
                            button26.BackColor = Color.Red;
                            break;
                        case 57:
                            button27.BackColor = Color.Red;
                            break;
                        case 58:
                            button28.BackColor = Color.Red;
                            break;
                        case 59:
                            button29.BackColor = Color.Red;
                            break;
                        case 60:
                            button30.BackColor = Color.Red;
                            break;
                        case 61:
                            button31.BackColor = Color.Red;
                            break;
                        case 62:
                            button32.BackColor = Color.Red;
                            break;
                        case 63:
                            button33.BackColor = Color.Red;
                            break;
                        case 64:
                            button34.BackColor = Color.Red;
                            break;
                        case 65:
                            button35.BackColor = Color.Red;
                            break;
                        case 66:
                            button36.BackColor = Color.Red;
                            break;
                        case 67:
                            button37.BackColor = Color.Red;
                            break;
                        case 68:
                            button38.BackColor = Color.Red;
                            break;
                        case 69:
                            button39.BackColor = Color.Red;
                            break;
                        case 70:
                            button40.BackColor = Color.Red;
                            break;
                        case 71:
                            button41.BackColor = Color.Red;
                            break;
                        case 72:
                            button42.BackColor = Color.Red;
                            break;
                        case 73:
                            button43.BackColor = Color.Red;
                            break;
                        case 74:
                            button44.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }

                }
            }


        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
        private void AsignarTags()
        {
            button1.Tag = 31;
            button2.Tag = 32;
            button3.Tag = 33;
            button4.Tag = 34;
            button5.Tag = 35;
            button6.Tag = 36;
            button7.Tag = 37;
            button8.Tag = 38;
            button9.Tag = 39;
            button10.Tag = 40;
            button11.Tag = 41;
            button12.Tag = 42;
            button13.Tag = 43;
            button14.Tag = 44;
            button15.Tag = 45;
            button16.Tag = 46;
            button17.Tag = 47;
            button18.Tag = 48;
            button19.Tag = 49;
            button20.Tag = 50;
            button21.Tag = 51;
            button22.Tag = 52;
            button23.Tag = 53;
            button24.Tag = 54;
            button25.Tag = 55;
            button26.Tag = 56;
            button27.Tag = 57;
            button28.Tag = 58;
            button29.Tag = 59;
            button30.Tag = 60;
            button31.Tag = 61;
            button32.Tag = 62;
            button33.Tag = 63;
            button34.Tag = 64;
            button35.Tag = 65;
            button36.Tag = 66;
            button37.Tag = 67;
            button38.Tag = 68;
            button39.Tag = 69;
            button40.Tag = 70;
            button41.Tag = 71;
            button42.Tag = 72;
            button43.Tag = 73;
            button44.Tag = 74;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
