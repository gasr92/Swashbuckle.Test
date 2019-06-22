using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Test.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Swashbuckle.Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Método de teste, somente para exemplificar
        /// </summary>
        /// <remarks>
        /// Exemplo:
        /// DELETE /Todo
        /// {
        ///     "id": 26
        /// }
        /// </remarks>
        /// <param name="id">Valor qualquer</param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public IActionResult ActionTeste(long id)
        {
            return View("Index");
        }

        /// <summary>
        /// Recebe um TodoItem
        /// </summary>
        /// <param name="p_todo"></param>
        /// <remarks>
        /// PUT /Home
        /// {
        ///     "Id": 10,
        ///     "Name": "Gabriel",
        ///     "IsActive": "true"
        /// }
        /// 
        /// </remarks>
        /// <returns>Retorno</returns>
        /// <response code="201">Especificar o que será retornado</response>
        [ProducesResponseType(201)]
        [HttpPut("p_todo")]
        public IActionResult Atualizar(TodoItem p_todo)
        {
            return Ok();
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
