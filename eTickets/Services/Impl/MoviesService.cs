using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Models;
using eTickets.Services.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Services.Impl
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
           return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }
    }

}
