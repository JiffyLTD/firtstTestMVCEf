using AutoCenter.Data;
using AutoCenter.Data.Interfaces;
using AutoCenter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCenter.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private readonly AppDBContent _content;
        public HomeController(IAllCars allCars , ICarsCategory carsCategory, AppDBContent content)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
            _content = content;
        }
        public ViewResult Index()
        {
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            ViewBag.Title = "Главная страница";
            ViewBag.Category = "Все автомобили";
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            var car = _content.Car.Find(id);
            _content.Car.RemoveRange(car);
            _content.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
