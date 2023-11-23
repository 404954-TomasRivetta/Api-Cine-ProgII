using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        private IAplicacionComprobante app;
        public ComprobanteController()
        {
            app = new AplicacionComprobante();
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;

            try
            {
                lst = app.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/empleados")]
        public IActionResult GetEmpleados()
        {
            List<Empleado> lst = null;

            try
            {
                lst = app.GetEmpleados();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/formas_pago")]
        public IActionResult GetFormasPago()
        {
            List<TipoFormaPago> lst = null;

            try
            {
                lst = app.GetFormasPagos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/AllPeliculas")]
        public IActionResult GetPeliculas()
        {
            List<Pelicula> lst = null;

            try
            {
                lst = app.GetPeliculas();
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }
        
        [HttpGet("/proxComprobante")]
        public IActionResult GetProxComprobante()
        {
            int nro = 0;
            try
            {
                nro = app.ObtenerProximoPresupuesto();
                return Ok(nro);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/proxButaca")]
        public IActionResult GetProxButaca()
        {
            int nro = 0;
            try
            {
                nro = app.ObtenerProximaButaca();
                return Ok(nro);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("/Funciones")]
        public IActionResult GetFunciones(int nro)
        {
            List<Funciones> lst = null;

            try
            {
                lst = app.TraerFunciones(nro);
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpGet("/Butacas")]
        public IActionResult GetButacas(int nro)
        {
            List<Butaca> lst = null;

            try
            {
                lst = app.TraerButacasOcupadas(nro);
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!!, intente luego");
            }
        }

        [HttpPost("/nuevoComprobante")]
        public IActionResult PostComprobante(Comprobante oC)
        {
            try
            {
                if (oC == null)
                {
                    return BadRequest("Comprobante Inválido,FALTAN CAMPOS...");
                }
                return Ok(app.SaveComprobante(oC));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno!!! Intente luego");
            }
        }
    }
}
