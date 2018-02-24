using MyListService.Business_Logic.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyListService.Business_Logic.Models;
using MyListService.Business_Logic.Repositories.DAL;

namespace MyListService.Business_Logic.Repositories
{
    public class ThingOnListRepository : IThingOnListRepository
    {
        private readonly MyListContext _context;

        public ThingOnListRepository(MyListContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ThingOnList thing)
        {
            await _context.ThingsOnList.AddAsync(thing);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<ThingOnList>> GetAllAsync()
            => Task.FromResult(_context.ThingsOnList.AsEnumerable());
    }
}
