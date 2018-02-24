using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyListService.Business_Logic.Models;

namespace MyListService.Business_Logic.Repositories.Interfaces
{
    public interface IThingOnListRepository
    {
        Task<IEnumerable<ThingOnList>> GetAllAsync();
        Task AddAsync(ThingOnList thing);
    }
}