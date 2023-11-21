using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmAltaPelicula : Form
    {
        Pelicula nueva = null;
        public FrmAltaPelicula()
        {
            InitializeComponent();
            nueva = new Pelicula();
        }

        private async void FrmAltaPelicula_Load(object sender, EventArgs e)
        {
            await CargarDirectoresAsync();
            await CargarTipoPublicoAsync();
            await CargarTipoPelicula();
            await CargarIdioma();
        }
        private async Task CargarDirectoresAsync()
        {
            string url = "https://localhost:7149/directores";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Director> lDirectores = JsonConvert.DeserializeObject<List<Director>>(dataJson);
            cboDirectores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDirectores.DataSource = lDirectores;
            cboDirectores.ValueMember = "IdDirector";
            cboDirectores.DisplayMember = "Nombre";
        }
        private async Task CargarTipoPublicoAsync()
        {
            string url = "https://localhost:7149/tipos_publico";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoPublico> lTiposPublico = JsonConvert.DeserializeObject<List<TipoPublico>>(dataJson);
            cboTipoPublico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPublico.DataSource = lTiposPublico;
            cboTipoPublico.ValueMember = "IdTipoPublico";
            cboTipoPublico.DisplayMember = "Descripcion";
        }
        private async Task CargarTipoPelicula()
        {
            string url = "https://localhost:7149/tipos_pelicula";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoPelicula> lPeliculas = JsonConvert.DeserializeObject<List<TipoPelicula>>(dataJson);
            cboTipoPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPelicula.DataSource = lPeliculas;
            cboTipoPelicula.ValueMember = "IdTipoPelicula";
            cboTipoPelicula.DisplayMember = "Descripcion";
        }
        private async Task CargarIdioma()
        {
            string url = "https://localhost:7149/dialectos";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Dialecto> lDialectos = JsonConvert.DeserializeObject<List<Dialecto>>(dataJson);
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.DataSource = lDialectos;
            cboIdioma.ValueMember = "IdIdioma";
            cboIdioma.DisplayMember = "Descripcion";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GrabarPelicula();
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar un nombre!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!rbtNo.Checked && !rbtSi.Checked)
            {
                MessageBox.Show("Debe seleccionar si esta subtitulada o no!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboDirectores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un director!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un idioma!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboTipoPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de pelicula!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboTipoPublico.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de publico!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        private async void GrabarPelicula()
        {
            ValidarDatos();
            nueva.Descripcion = txtDescripcion.Text;
            nueva.IdDirector = (int)cboDirectores.SelectedValue;
            nueva.IdTipoPelicula = (int)cboTipoPelicula.SelectedValue;
            nueva.IdTipoPublico = (int)cboTipoPublico.SelectedValue;
            nueva.IdIdioma = (int)cboIdioma.SelectedValue;

            if (rbtSi.Checked)
            {
                nueva.Subtitulada = 1;
            }
            else if (rbtNo.Checked)
            {
                nueva.Subtitulada = 2;
            }
            await GuardarPeliculAsync(nueva);
        }
        private async Task GuardarPeliculAsync(Pelicula nueva)
        {
            string url = "https://localhost:7149/pelicula";
            string peliculaJson = JsonConvert.SerializeObject(nueva);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, peliculaJson);

            if (dataJson.Equals("true"))
            {
                MessageBox.Show("Se registró con exito la pelicula", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la pelicula", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void rbtSi_CheckedChanged(object sender, EventArgs e)
        {

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
