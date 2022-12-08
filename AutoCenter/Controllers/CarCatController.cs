using AutoCenter.Data.Interfaces;
using AutoCenter.Data.Models;
using AutoCenter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCenter.Controllers
{
    public class CarCatController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarCatController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("inomarki", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("иномарка")).OrderBy(i => i.Id);
                    ViewBag.Title = "Иномарки";
                    ViewBag.Category = "Иномарки";
                }
                else 
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("отечественная")).OrderBy(i => i.Id);
                    ViewBag.Title = "Отечественные авто";
                    ViewBag.Category = "Отечественные авто";
                }

                currCategory = _category;
            }
            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                currCategory = currCategory
            };

            return View(carObj);
        }
    }
}
