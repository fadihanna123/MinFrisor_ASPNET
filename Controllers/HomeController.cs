using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly HairdresserContext _context;


        public HomeController(HairdresserContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.Blog.ToListAsync());

        }

 
        [Route("Priser")]
        public IActionResult Prices()
        {
            return View();
        }


        [Route("Om")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Utbildning")]
        public IActionResult Course()
        {
            return View();
        }

        [Route("Kontakt")]
        public IActionResult Contact()
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
