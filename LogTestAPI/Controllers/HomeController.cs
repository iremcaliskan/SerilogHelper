using LogHelper.Logging.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogTestAPI.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        { // Ex. Logging is done when Index runs - Örneğin, Index çalıştığı an loglama yapılacak
            var message = new { FirstName = "İrem", LastName = "Çalışkan", Message = "Bu bir test mesajıdır." };
            LoggerFactory.DatabaseLogManager().Information("{@message}", message);
            LoggerFactory.FileLogManager().Information(" Ekstra mesajım burada: " + "{@message}", message );
            return View();
        }
    }
}
