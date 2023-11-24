using CineBack.Entidades;
using CineFront.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

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
        private async Task GuardarClienteAsync()
        {
            if (ValidarDatos())
            {
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.NroTel = (int)Convert.ToInt64(txtNroTel.Text);
                //if (txtCorreo.Text == "")
                //{
                //    nuevo.Correo = "";
                //}
                //else
                //{
                nuevo.Correo = txtCorreo.Text;
                //}
                nuevo.CodBarrio = (int)Convert.ToInt64(cboBarrios.SelectedValue);
                nuevo.Calle = txtCalle.Text;
                nuevo.CalleNro = Convert.ToInt32(txtAltura.Text);
                nuevo.Dni = (int)Convert.ToInt64(txtDni.Text);
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
