using eTickets.Data;
using eTickets.Models;
using eTickets.Services.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Services.Impl
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext context;

        public ProducersService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Producer producer)
        {
            await context.Producers.AddAsync(producer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var producer = await context.Producers.FirstOrDefaultAsync(p => p.Id == id);
            context.Producers.Remove(producer);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var producers = await context.Producers.ToListAsync();

            return producers;
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var producer = await context.Producers.FirstOrDefaultAsync(p => p.Id == id);
            return producer;
        }

        public async Task<Producer> UpdateAsync(int id, Producer newProducer)
        {
            context.Producers.Update(newProducer);
            await context.SaveChangesAsync();
            return newProducer;
        }
    }
}
