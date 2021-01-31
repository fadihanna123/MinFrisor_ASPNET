using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class BookingssystemController : Controller
    {
        private readonly HairdresserContext _context;

        public BookingssystemController(HairdresserContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Bookingssystem.ToListAsync());
        }


        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Mail,MobilNumber,Service,Date,Time")] Bookingssystem bookingssystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingssystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingssystem);
        }



    }
}
