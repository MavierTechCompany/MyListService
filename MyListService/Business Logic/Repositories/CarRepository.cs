using MyListService.Business_Logic.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyListService.Business_Logic.Models;
using MyListService.Business_Logic.Repositories.DAL;

namespace MyListService.Business_Logic.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly MyListContext _context;

        public CarRepository(MyListContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Car>> GetAllAsync()
            => Task.FromResult(_context.Cars.AsEnumerable());
    }
}
