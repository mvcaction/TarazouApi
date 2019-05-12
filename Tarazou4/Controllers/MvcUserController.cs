using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.Exceptions;

using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Tarazou4.Entities;
namespace Tarazou4.Controllers
{
    public class MvcUserController : Controller
    {
        CancellationToken cancellationToken;
        private readonly IUserRepository userRepository;


        public MvcUserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        // GET: MvcUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: MvcUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MvcUser/Create
        public ActionResult Create()
        {
            List<Province> province = new List<Province>()
            {
new Province {Id=1,Name="آذربایجان شرقی" },
new Province {Id=2,Name="آذربایجان غربی" },
new Province {Id=3,Name="اردبیل" },
new Province {Id=4,Name="اصفهان" },
new Province {Id=5,Name="البرز" },
new Province {Id=6,Name="ایلام" },
new Province {Id=7,Name="بوشهر" },
new Province {Id=8,Name="تهران" },
new Province {Id=9,Name="چهارمحال وبختیاری" },
new Province {Id=10,Name="خراسان جنوبی" },
new Province {Id=11,Name="خراسان رضوی" },
new Province {Id=12,Name="خراسان شمالی" },
new Province {Id=13,Name="خوزستان" },
new Province {Id=14,Name="زنجان" },
new Province {Id=15,Name="سمنان" },
new Province {Id=16,Name="سیستان وبلوچستان" },
new Province {Id=17,Name="فارس" },
new Province {Id=18,Name="قزوین" },
new Province {Id=19,Name="قم" },
new Province {Id=20,Name="کردستان" },
new Province {Id=21,Name="کرمان" },
new Province {Id=22,Name="کرمانشاه" },
new Province {Id=23,Name="کهگیلویه وبویراحمد" },
new Province {Id=24,Name="گلستان" },
new Province {Id=25,Name="گیلان" },
new Province {Id=26,Name="لرستان" },
new Province {Id=27,Name="مازندران" },
new Province {Id=28,Name="مرکزی" },
new Province {Id=29,Name="هرمزگان" },
new Province {Id=30,Name="همدان" },
new Province {Id=31,Name="یزد" },



            };
            ViewData["heading"] = province.ToList();
            return View();
        }

        // POST: MvcUser/Create
        [HttpPost]
        public ActionResult Create(User userDto)
        {

            var user = new User
            {
                Guid = Guid.NewGuid(),
                Username = userDto.Username,
                FirstName = userDto.FirstName,
                Mobile = userDto.Mobile,
                MobileVerificationCode = "123",
                LastName = userDto.LastName,
                Password = userDto.Password,
                PasswordSalt = "123",
                ProvinceId = userDto.ProvinceId,
                IsVerify = true,
                Credit = 120,
                CreatedOnUtc = DateTime.Now,
                Active =true
            };
            userRepository.AddAsync(user, cancellationToken);

            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MvcUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MvcUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
               
            }
        }
       
    }
}