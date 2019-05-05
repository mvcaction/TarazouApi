using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tarazou4.Entities;

namespace TarazouMvc.Controllers
{
    public class QuestionsMvcController : Controller
    {
        CancellationToken cancellationToken;
        private readonly IQuestionRepository questionRepository;
        private readonly IQuestionCategoryRepository questioncategoryRepository;


        public QuestionsMvcController(IQuestionRepository questionRepository,IQuestionCategoryRepository questionCategoryRepository)
        {
            this.questionRepository = questionRepository;
            this.questioncategoryRepository = questionCategoryRepository;
        }
     

        // GET: QuestionsMvc
        public async Task<IActionResult> Index()
        {
            return View ();
        }

        // GET: QuestionsMvc/Details/5
        public async Task<IActionResult> GetQuestionById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await questionRepository.GetByIdAsync(cancellationToken, id);

            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // GET: QuestionsMvc/Create
        public async  Task< IActionResult> Create()
        {
           var questions =await questioncategoryRepository.TableNoTracking.ToListAsync();


            ViewData["QuestionCategoryId"] = new SelectList(questions.ToList(), "Name");

            //ViewData["QuestionTypeId"] = new SelectList(_context.QuestionType, "Id", "Name");

            return View();
        }

        // POST: QuestionsMvc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,QuestionCategoryId")] Question questionDto)
        {
            if (ModelState.IsValid)
            {

                var question = new Question
                {
                    Title = questionDto.Title,
                    Description = questionDto.Description,
                    QuestionCategoryId = questionDto.QuestionCategoryId,
                    QuestionTypeId = questionDto.QuestionTypeId,
                    Price = questionDto.Price,
                    Active = questionDto.Active,
                    UserId = questionDto.UserId,
                    CreatedOnUtc = questionDto.CreatedOnUtc,
                    IsPay = questionDto.IsPay,
                    LastStatusId = questionDto.LastStatusId,
                    Score = questionDto.Score,
                    Immediate = questionDto.Immediate,
                    ScoreConsultant = questionDto.ScoreConsultant
                };
                await questionRepository.AddAsync(question, cancellationToken);
                return RedirectToAction(nameof(Index));
            }

            //ViewData["LastStatusId"] = new SelectList(_context.QuestionStatus, "Id", "Name", question.LastStatusId);
           //ViewData["QuestionCategoryId"] = new SelectList(questions, "Id", "Name", questions.Select(x=>x.Id));
            //ViewData["QuestionTypeId"] = new SelectList(_context.QuestionType, "Id", "Name", question.QuestionTypeId);
            //ViewData["SelectConsultantId"] = new SelectList(_context.Consultant, "Id", "Address", question.SelectConsultantId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "FirstName", question.UserId);
            //return View(question);
            return RedirectToAction(nameof(Index));

        }

        // GET: QuestionsMvc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var question = await _context.Question.FindAsync(id);
            //if (question == null)
            //{
            //    return NotFound();
            //}
            //ViewData["LastStatusId"] = new SelectList(_context.QuestionStatus, "Id", "Name", question.LastStatusId);
            //ViewData["QuestionCategoryId"] = new SelectList(_context.QuestionCategory, "Id", "Name", question.QuestionCategoryId);
            //ViewData["QuestionTypeId"] = new SelectList(_context.QuestionType, "Id", "Name", question.QuestionTypeId);
            //ViewData["SelectConsultantId"] = new SelectList(_context.Consultant, "Id", "Address", question.SelectConsultantId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "FirstName", question.UserId);

            return View();
        }

        // POST: QuestionsMvc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,QuestionCategoryId,QuestionTypeId,Price,Active,UserId,CreatedOnUtc,UpdatedOnUtc,IsPay,PaymentDate,LastStatusId,LastUpdateTime,SelectConsultantId,Score,LastAnsweringTime,Immediate,AllowedAnsweringTime,ScoreConsultant")] Question question)
        {
            if (id != question.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            //    //try
            //    //{
            //    //    _context.Update(question);
            //    //    await _context.SaveChangesAsync();
            //    //}
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!QuestionExists(question.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //}

            return RedirectToAction(nameof(Index));

            //ViewData["LastStatusId"] = new SelectList(_context.QuestionStatus, "Id", "Name", question.LastStatusId);
            //ViewData["QuestionCategoryId"] = new SelectList(_context.QuestionCategory, "Id", "Name", question.QuestionCategoryId);
            //ViewData["QuestionTypeId"] = new SelectList(_context.QuestionType, "Id", "Name", question.QuestionTypeId);
            //ViewData["SelectConsultantId"] = new SelectList(_context.Consultant, "Id", "Address", question.SelectConsultantId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "FirstName", question.UserId);

            return View(question);
        }

        // GET: QuestionsMvc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var question = await _context.Question
            //    .Include(q => q.LastStatus)
            //    .Include(q => q.QuestionCategory)
            //    .Include(q => q.QuestionType)
            //    .Include(q => q.SelectConsultant)
            //    .Include(q => q.User)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (question == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // POST: QuestionsMvc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
        //    var question = await _context.Question.FindAsync(id);
        //    _context.Question.Remove(question);
        //    await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool QuestionExists(int id)
        //{
        //    return _context.Question.Any(e => e.Id == id);
        //}
    }
}
