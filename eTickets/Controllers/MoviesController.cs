using eTickets.Data;
using eTickets.Services.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            this._service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync();
            return View(allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetByIdAsync(id);
            if (movieDetail == null)
            {
                return View("NotFound");
            }
            return View(movieDetail);
        }
    }
}
