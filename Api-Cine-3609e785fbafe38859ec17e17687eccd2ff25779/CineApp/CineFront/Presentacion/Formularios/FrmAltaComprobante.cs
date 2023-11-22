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
            await CargarClientesAsync();
            await CargarFormasPagoAsync();
            await CargarEmpleadosAsync();
            await CargarPeliculasAsync();
            //await ProximoComprobante();
        }

        //private async Task<int> ProximoComprobante()
        //{

        //    string url = "https://localhost:7149/proxComprobante";
        //    var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
        //    var lst = JsonConvert.DeserializeObject<int>(bodyJson);
        //    txtProximoComprobante.Text = txtProximoComprobante.Text + Convert.ToInt32(lst);
        //    return lst;
        //}

        //private async Task<int> ProximaButaca()
        //{

        //    string url = "https://localhost:7149/proxButaca";
        //    var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
        //    var nro = JsonConvert.DeserializeObject<int>(bodyJson);
        //    return nro;
        //}



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

        //private async Task GuardarComprobanteAsync()
        //{
        //    TipoFormaPago t = (TipoFormaPago)cboFormasP.SelectedItem;
        //    Cliente c = (Cliente)cboClientes.SelectedItem;
        //    Empleado e = (Empleado)cboEmpleado.SelectedItem;
        //    nuevo.IdCliente = c.CodCliente;
        //    nuevo.IdForma_pago = t.id;
        //    nuevo.IdEmpleado = e.CodEmpleado;
        //    nuevo.CantEntradas = Convert.ToInt32(cantEntradas.Value);
        //    string bodyContent = JsonConvert.SerializeObject(nuevo);

        //    string url = "https://localhost:7149/api/Comprobante";
        //    var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

        //    if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)    
        //    {
        //        MessageBox.Show("Presupuesto registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Dispose();
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

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

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    ValidarDatos();

        //    //int butacaFila = Convert.ToInt32(nudFila.Value);
        //    //int butacaColumna = Convert.ToInt32(nudColumna.Value);
        //    int preUnitario = Convert.ToInt32(txtPreUnitario.Text);
        //    Pelicula p = (Pelicula)cboPeliculas.SelectedItem;
        //    Funciones f = (Funciones)cboFechaHora.SelectedItem;


        //    dgvTickets.Rows.Add(new object[] { /*butacaFila, butacaColumna,*/ preUnitario, p.Descripcion, f.FechaHora, "Quitar ඞ" });

        //    Butaca b = new Butaca();
        //    //b.Fila = Convert.ToInt32(nudFila.Value);
        //    //b.Columna = Convert.ToInt32(nudColumna.Value);
        //    b.EstadoButaca = 1;
        //    b.IdFuncion = f.IdFuncion;


        //    Tickets t = new Tickets();
        //    t.PreUnitario = preUnitario;
        //    //t.IdComprobante = Convert.ToInt32(ProximoComprobante());
        //    t.IdComprobante = 30;
        //    //t.butaca = b;
        //    //t.IdButaca = Convert.ToInt32(ProximaButaca());
        //    nuevo.AgregarTicket(t);

        //}
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
                //MessageBox.Show($"Manejador de eventos asignado a {boton.Name}");
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            if (boton != null)
            {
                if (boton.BackColor == Color.Lime)
                {
                    boton.BackColor = Color.Red;
                }
                else
                {
                    boton.BackColor = Color.Lime;
                }

                Console.WriteLine($"Boton {boton.Name} - Color de fondo: {boton.BackColor}");
            }
        }
        private int IdButaca()
        {
            // Encuentra el primer botón con color rojo
            Button botonSeleccionado = this.Controls.OfType<Button>().FirstOrDefault(b => b.BackColor == Color.Red);

            if (botonSeleccionado != null && botonSeleccionado.Tag != null)
            {
                // Si el botón tiene un Tag válido, devuelve su ID
                return Convert.ToInt32(botonSeleccionado.Tag);
            }

            // Si no se encontró un botón rojo válido, devuelve 0 o maneja el caso según sea necesario
            return 0;
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

        //private int IdButaca()
        //{

        //    if (button1.BackColor == Color.Red)
        //    {
        //        return 31;
        //    }
        //    if (button2.BackColor == Color.Red)
        //    {
        //        return 32;
        //    }
        //    if (button3.BackColor == Color.Red)
        //    {
        //        return 33;
        //    }
        //    if (button4.BackColor == Color.Red)
        //    {
        //        return 34;
        //    }
        //    if (button5.BackColor == Color.Red)
        //    {
        //        return 35;
        //    }
        //    if (button6.BackColor == Color.Red)
        //    {
        //        return 36;
        //    }
        //    if (button7.BackColor == Color.Red)
        //    {
        //        return 37;
        //    }
        //    if (button8.BackColor == Color.Red)
        //    {
        //        return 38;
        //    }
        //    if (button9.BackColor == Color.Red)
        //    {
        //        return 39;
        //    }
        //    if (button10.BackColor == Color.Red)
        //    {
        //        return 40;
        //    }
        //    if (button11.BackColor == Color.Red)
        //    {
        //        return 41;
        //    }
        //    if (button12.BackColor == Color.Red)
        //    {
        //        return 42;
        //    }
        //    if (button13.BackColor == Color.Red)
        //    {
        //        return 43;
        //    }
        //    if (button14.BackColor == Color.Red)
        //    {
        //        return 44;
        //    }
        //    if (button15.BackColor == Color.Red)
        //    {
        //        return 45;
        //    }
        //    if (button16.BackColor == Color.Red)
        //    {
        //        return 46;
        //    }
        //    if (button17.BackColor == Color.Red)
        //    {
        //        return 47;
        //    }
        //    if (button18.BackColor == Color.Red)
        //    {
        //        return 48;
        //    }
        //    if (button19.BackColor == Color.Red)
        //    {
        //        return 49;
        //    }
        //    if (button20.BackColor == Color.Red)
        //    {
        //        return 50;
        //    }
        //    if (button21.BackColor == Color.Red)
        //    {
        //        return 51;
        //    }
        //    if (button22.BackColor == Color.Red)
        //    {
        //        return 52;
        //    }
        //    if (button23.BackColor == Color.Red)
        //    {
        //        return 53;
        //    }
        //    if (button24.BackColor == Color.Red)
        //    {
        //        return 54;
        //    }
        //    if (button25.BackColor == Color.Red)
        //    {
        //        return 55;
        //    }
        //    if (button26.BackColor == Color.Red)
        //    {
        //        return 56;
        //    }
        //    if (button27.BackColor == Color.Red)
        //    {
        //        return 57;
        //    }
        //    if (button28.BackColor == Color.Red)
        //    {
        //        return 58;
        //    }
        //    if (button29.BackColor == Color.Red)
        //    {
        //        return 59;
        //    }
        //    if (button30.BackColor == Color.Red)
        //    {
        //        return 60;
        //    }
        //    if (button31.BackColor == Color.Red)
        //    {
        //        return 61;
        //    }
        //    if (button32.BackColor == Color.Red)
        //    {
        //        return 62;
        //    }
        //    if (button33.BackColor == Color.Red)
        //    {
        //        return 63;
        //    }
        //    if (button34.BackColor == Color.Red)
        //    {
        //        return 64;
        //    }
        //    if (button35.BackColor == Color.Red)
        //    {
        //        return 65;
        //    }
        //    if (button36.BackColor == Color.Red)
        //    {
        //        return 66;
        //    }
        //    if (button37.BackColor == Color.Red)
        //    {
        //        return 67;
        //    }
        //    if (button38.BackColor == Color.Red)
        //    {
        //        return 68;
        //    }
        //    if (button39.BackColor == Color.Red)
        //    {
        //        return 69;
        //    }
        //    if (button40.BackColor == Color.Red)
        //    {
        //        return 70;
        //    }
        //    if (button41.BackColor == Color.Red)
        //    {
        //        return 71;
        //    }
        //    if (button42.BackColor == Color.Red)
        //    {
        //        return 72;
        //    }
        //    if (button43.BackColor == Color.Red)
        //    {
        //        return 73;
        //    }
        //    if (button44.BackColor == Color.Red)
        //    {
        //        return 74;
        //    }
        //    return 70;
        //}


        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            await GrabarComprobanteAsync();
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
            ValidarDatos();
            //List<Button> botonesSeleccionados = this.Controls.OfType<Button>().Where(b => b.BackColor == Color.Red).ToList();
            //if (botonesSeleccionados.Count == 0)
            //{
            //    MessageBox.Show("Seleccione al menos una butaca para continuar.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            int idbut = IdButaca();
            Tickets tic = new Tickets();
            tic.PreUnitario = Convert.ToDouble(txtPreUnitario.Text);
            tic.IdButaca = idbut;
            Pelicula peli = (Pelicula)cboPeliculas.SelectedItem;

            nuevo.AgregarTicket(tic);
            dgvTickets.Rows.Add(new object[] { tic.PreUnitario, peli.Descripcion, cboFechaHora.Text });







            //    List<Button>botonesSeleccionados = new List<Button>();
            //    foreach (Control control in this.Controls)
            //    {
            //        if(control is Button boton && boton.BackColor == Color.Red)
            //        {
            //            botonesSeleccionados.Add(boton);
            //        }
            //    }
            //    if (botonesSeleccionados.Count == 0)
            //    {
            //        MessageBox.Show("Seleccione al menos una butaca para continuar.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //        Pelicula pel = (Pelicula)cboPeliculas.SelectedItem;
            //    foreach (Button botonSeleccionado in botonesSeleccionados)
            //    {
            //        if (botonSeleccionado.Tag != null && int.TryParse(botonSeleccionado.Tag.ToString(), out int idBoton))
            //        {
            //            Tickets ti = new Tickets();
            //            ti.IdButaca = idBoton;
            //            ti.PreUnitario = Convert.ToDouble(txtPreUnitario.Text);
            //            //ti.IdComprobante = Convert.ToInt32(ProximoComprobante());
            //            ti.IdComprobante = 30;
            //            nuevo.AgregarTicket(ti);
            //            dgvTickets.Rows.Add(new object[] { ti.PreUnitario, pel.Descripcion, "insertar horario aca", "Quitar" });
            //        }
            //        else
            //        {
            //            MessageBox.Show("El botón seleccionado no tiene un identificador válido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //
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
    }
}
