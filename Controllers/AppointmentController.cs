using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication2.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
         /*   string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);
*/

        }
        public IActionResult Detailes(int id)
        {
            return Ok("this is what  id"+id);
        }
    }
}
