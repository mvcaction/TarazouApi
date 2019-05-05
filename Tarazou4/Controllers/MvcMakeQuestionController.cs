using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarazou4.Entities;
using WebFramework.Api;

namespace Tarazou4.Controllers
{
    public class MvcMakeQuestionController : Controller
    {
        // GET: MvcMakeQuestion
        public ActionResult Index()
        {
            return View();
        }

        // GET: MvcMakeQuestion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MvcMakeQuestion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MvcMakeQuestion/Create
        [HttpPost]
        public async Task<ApiResult<Question>> Create(Question questionDto)
{
            //var exists = await userRepository.TableNoTracking.AnyAsync(p => p.UserName == userDto.UserName);
            //if (exists)
            //    return BadRequest("نام کاربری تکراری است");

            return null;
        }

        // GET: MvcMakeQuestion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MvcMakeQuestion/Edit/5
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

        // GET: MvcMakeQuestion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MvcMakeQuestion/Delete/5
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