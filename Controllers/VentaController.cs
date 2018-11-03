using Microsoft.AspNetCore.Mvc;


namespace  Reset.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult RegistrarOrdenCompra()
        {
           return View();
        }
        public IActionResult GenerarComprobante()
        {
           return View();
        }
    }
}