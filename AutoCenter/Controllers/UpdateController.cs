using AutoCenter.Data;
using AutoCenter.Data.Interfaces;
using AutoCenter.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCenter.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private readonly AppDBContent _content;
        public UpdateController(IAllCars allCars, ICarsCategory carsCategory, AppDBContent content)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
            _content = content;
        }
        public ViewResult UpdateCar(int? id)
        {
            ViewBag.Title = "Новые авто";
            ViewBag.Category = "Изменить данные авто";

            var car = _content.Car.Find(id);
            return View(car);
        }
        [HttpPost]
        public IActionResult UpdateCar([Bind("Id,CompanyName,CarModel,Desc,Price,Img,CategoryID")]Car car)
        {
            _content.Update(car);
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
