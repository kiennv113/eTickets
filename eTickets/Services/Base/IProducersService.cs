using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Services.Base
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task AddAsync(Producer actor);
        Task<Producer> UpdateAsync(int id, Producer newProducer);
        Task DeleteAsync(int id);
    }
}
