using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmReportePeliculas : Form
    {
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void FrmReportePeliculas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.RptPeliculas.rdlc";


            string connectionString = @"Data Source=PCCesar;Initial Catalog=lc_tpi_cine;Integrated Security=True;Encrypt=False";
            string query = "select p.descripcion as pelicula, sum(cant_entradas * pre_unitario)/2 as Facturacion from comprobantes c join tickets t on t.id_comprobante=c.id_comprobante join butacas b on t.id_butacas = b.id_butaca join funciones f on f.id_funcion = c.id_funcion join peliculas p on p.id_pelicula = f.id_pelicula GROUP BY p.descripcion order by Facturacion  DESC";
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(query, new SqlConnection(connectionString)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }
            }

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
            reportViewer1.RefreshReport();
        }
    }
}
