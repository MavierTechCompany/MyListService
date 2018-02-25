using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyListService.Business_Logic.Models;
using MyListService.Business_Logic.Repositories.Interfaces;

namespace MyListService.Controllers
{
    public class HomeController : Controller
    {
        public readonly ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return await Task.FromResult(View());
        }

        [HttpPost]
        public async Task<IActionResult> Index(Car car)
        {
            await _carRepository.AddAsync(car);

            return View("MyList");
        }

        [HttpGet]
        public async Task<IActionResult> MyList()
        {
            var cars = await _carRepository.GetAllAsync();

            return await Task.FromResult(View(cars));
        }
    }
}
