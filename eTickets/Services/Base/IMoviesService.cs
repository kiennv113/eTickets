using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Services.Base
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        //Task AddAsync(Movie movie);
        //Task<Movie> UpdateAsync(int id, Movie newMovie);
        //Task DeleteAsync(int id);
    }
}
