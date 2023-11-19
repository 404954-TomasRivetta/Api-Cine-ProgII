using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmModificacionPelicula : Form
    {
        private int idPelicula;

        public FrmModificacionPelicula(int idPelicula)
        {
            InitializeComponent();

            this.idPelicula = idPelicula;

        }

        private async void FrmModificacionPelicula_Load(object sender, EventArgs e)
        {
            await CargarDirectoresAsync();
            await CargarTipoPublicoAsync();
            await CargarTipoPelicula();
            await CargarIdioma();

            txtNumPelicula.Text = txtNumPelicula.Text + ' ' + idPelicula.ToString();

            CargarDatosAntiguosAsync();
        }

        private async void CargarDatosAntiguosAsync()
        {
            string url = string.Format("https://localhost:7149/pelicula/{0}", idPelicula);
            var result = await ClienteSingleton.GetInstance().GetAsync(url);

            var pelicula = JsonConvert.DeserializeObject<Pelicula>(result);
            if (pelicula != null)
            {
                txtDescripcion.Text = pelicula.Descripcion;
                cboDirectores.SelectedValue = pelicula.IdDirector;
                cboIdioma.SelectedValue = pelicula.IdIdioma;
                cboTipoPelicula.SelectedValue = pelicula.IdTipoPelicula;
                cboTipoPublico.SelectedValue = pelicula.IdTipoPublico;

                if (pelicula.Subtitulada == 1)
                {
                    rbtSi.Checked = true;
                }
                else
                {
                    rbtNo.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("No se pudo recuperar información de la pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GuardarPelicula();

        }

        private async void GuardarPelicula()
        {
            Pelicula p = new Pelicula();

            p.IdPelicula = idPelicula;
            p.Descripcion = txtDescripcion.Text;
            p.IdTipoPelicula = Convert.ToInt32(cboTipoPelicula.SelectedValue);
            p.IdTipoPublico = Convert.ToInt32(cboTipoPublico.SelectedValue);
            p.IdIdioma = Convert.ToInt32(cboIdioma.SelectedValue);
            p.IdDirector = Convert.ToInt32(cboDirectores.SelectedValue);

            if (rbtSi.Checked)
            {
                p.Subtitulada = 1;
            }
            else
            {
                p.Subtitulada = 2;
            }

            string bodyContent = JsonConvert.SerializeObject(p);
            string url = "https://localhost:7149/pelicula_modificar/" + idPelicula;

            var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Pelicula actualizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo actualizar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
