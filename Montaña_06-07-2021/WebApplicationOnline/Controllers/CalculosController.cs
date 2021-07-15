using Microsoft.AspNetCore.Mvc;


namespace WebApplicationOnline.Controllers
{
    public class CalculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
         [HttpPost]
        public IActionResult Sumar(int primerNumero, int segundoNumero)
        {
            //cant access Sequest Form in asp .net core
            //Request.Form
            var primeroNumeroFromBody = int.Parse(Request.Form["primerNumero"]);
            var segundoNumeroFromBody = int.Parse(Request.Form["segundoNumero"]);
            var resultadoFromBody = primeroNumeroFromBody + segundoNumeroFromBody;
            var resultado = primerNumero + segundoNumero;
            ViewData["Resultado"] = resultado;
            ViewData["resultadoFromBody"] = resultadoFromBody;

            return View();
        }
    }
}
