using System;
using System.Collections.Generic;
using System.Linq;
using LumiaProject.DAL;
using LumiaProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LumiaProject.Controllers
{
	public class HomeController:Controller
	{
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
		public IActionResult Index()
        {

            List<Testimonial> testimonial = context.Testimonials.Include(x => x.Position).ToList();
			return View(testimonial);
        }
		public IActionResult About()
        {
			return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}

