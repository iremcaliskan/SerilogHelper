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
            LoggerFactory.DatabaseLogManager().Information("Addition of {@message} is starting!", message);
            LoggerFactory.FileLogManager().Information("Addition of {@message} is starting!", message);

            try
            {
                if (message != null)
                {
                    throw new Exception("Sample Error");
                }
            }
            catch (Exception e)
            {
                LoggerFactory.DatabaseLogManager().Error(e, "Addition of {@message} encountered an error: {1}", message, e.Message);
                LoggerFactory.FileLogManager().Error(e, "Addition of {@message} encountered an error: {1}", message, e.Message);
            }

            return View();
        }
    }
}
