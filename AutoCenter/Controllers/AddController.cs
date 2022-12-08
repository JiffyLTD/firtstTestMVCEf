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
    public class AddController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private readonly AppDBContent _content;
        public AddController(IAllCars allCars, ICarsCategory carsCategory, AppDBContent content)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
            _content = content;
        }
        public ViewResult AddCar()
        {
            ViewBag.Title = "Новые авто";
            ViewBag.Category = "Добавить авто";

            return View("AddCar");
        }
        public ViewResult AddNewCar()
        {
            ViewBag.Title = "Новые авто";
            ViewBag.Category = "Добавить свое авто";

            return View("AddYourCar");
        }
        [HttpPost]
        public IActionResult AddCar([Bind("Id,CompanyName,CarModel,Desc,Price,Img,CategoryID")] Car car)
        {
            _content.AddRange(car);
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AddBMWM5()
        {
            _content.AddRange(
                new Car
                {
                    CompanyName = "BMW",
                    CarModel = "M5",
                    Desc = "Вроде едет, уже неплохо",
                    Price = 3400000,
                    Img = "https://www.avtorinok.ru/photo/pics/bmw/m5-f90/186998.jpg",
                    CategoryID = 1
                }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddBMWM3()
        {
            _content.AddRange(
                new Car
                {
                    CompanyName = "BMW",
                    CarModel = "M3",
                    Desc = "Отлично едет",
                    Price = 4300000,
                    Img = "https://images.drive.ru/i/0/5f6b2087ec05c4011100008b.jpg",
                    CategoryID = 1
                }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddBMWX5()
        {
            _content.AddRange(
                new Car
                {
                    CompanyName = "BMW",
                    CarModel = "X5",
                    Desc = "Большой и злой",
                    Price = 1800000,
                    Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                    CategoryID = 1
                }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddMersedesBenzE()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Mersedes-Benz",
                     CarModel = "E-Class",
                     Desc = "Комфорт",
                     Price = 2200000,
                     Img = "https://avatars.mds.yandex.net/get-verba/997355/2a00000176b7d3f6a4f92df665019bd8cd6f/cattouchret",
                     CategoryID = 1
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddMersedesBenzС()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Mersedes-Benz",
                     CarModel = "С-Class",
                     Desc = "Комфорт+",
                     Price = 3200000,
                     Img = "https://cdn.motor1.com/images/mgl/k3pee/s1/mercedes-c-klasse-limousine-2021.jpg",
                     CategoryID = 1
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddMersedesBenzA()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Mersedes-Benz",
                     CarModel = "A-Class",
                     Desc = "Типо гольф",
                     Price = 1200000,
                     Img = "https://s.auto.drom.ru/i24211/r/photos/480103/1229871.jpg",
                     CategoryID = 1
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddLadaPriora()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Lada",
                     CarModel = "Priora",
                     Desc = "Шикарный авто, для шикарных людей",
                     Price = 450000,
                     Img = "https://quto.ru/thumb/0x678/filters:quality(75):no_upscale()/imgs/2020/10/21/09/4246866/58d9df36d61a5564d6f9876e7b4627fd01976b3f.jpg",
                     CategoryID = 2
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddLada2114()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Lada",
                     CarModel = "2114",
                     Desc = "Ваяяяяяяяя",
                     Price = 160000,
                     Img = "https://carakoom.com/data/wall/787/63ac02fa_medium.jpg",
                     CategoryID = 2
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddLada2110()
        {
            _content.AddRange(
                 new Car
                 {
                     CompanyName = "Lada",
                     CarModel = "2110",
                     Desc = "Чирик",
                     Price = 120000,
                     Img = "https://a.d-cd.net/b2f5fb9s-960.jpg",
                     CategoryID = 2
                 }
                );
            _content.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
