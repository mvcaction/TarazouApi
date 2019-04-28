﻿using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tarazou4.Entities;
using WebFramework.Api;
using WebFramework.Filters;

namespace Tarazou4.Controllers
{
    [Route("api/[controller]")]
    [ApiResultFilter]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private readonly IQuestionRepository questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> Get(CancellationToken cancellationToken)
        {
            var questions = await questionRepository.TableNoTracking.ToListAsync(cancellationToken);
            return Ok(questions);
        }

        [HttpGet("{id:int}")]
        public async Task<ApiResult<Question>> Get(int id, CancellationToken cancellationToken)
        {
            var question = await questionRepository.GetByIdAsync(cancellationToken, id);
            if (question == null)
                return NotFound();
            return question;
        }

        [HttpPost]
        public async Task<ApiResult<Question>> Create(Question userDto, CancellationToken cancellationToken)
        {
            //var exists = await userRepository.TableNoTracking.AnyAsync(p => p.UserName == userDto.UserName);
            //if (exists)
            //    return BadRequest("نام کاربری تکراری است");

            var question = new Question
            {
                Title = userDto.Title,
                Description = userDto.Description,
                QuestionCategoryId = userDto.QuestionCategoryId,
                QuestionTypeId = userDto.QuestionTypeId,
                Price = userDto.Price,
                Active = userDto.Active,
                UserId = userDto.UserId,
                CreatedOnUtc = userDto.CreatedOnUtc,
                IsPay = userDto.IsPay,
                LastStatusId = userDto.LastStatusId,
                Score = userDto.Score,
                Immediate = userDto.Immediate,
                ScoreConsultant = userDto.ScoreConsultant
            };
            await questionRepository.AddAsync(question, cancellationToken);
            return question;
        }

        [HttpPut]
        public async Task<ApiResult> Update(int id, Question user, CancellationToken cancellationToken)
        {
            var updatequestion = await questionRepository.GetByIdAsync(cancellationToken, id);

            updatequestion.Title = user.Title;
            updatequestion.Description = user.Description;
            updatequestion.QuestionCategoryId = user.QuestionCategoryId;
            updatequestion.QuestionTypeId= user.QuestionTypeId;
            updatequestion.IsPay = user.IsPay;
            updatequestion.LastStatusId = user.LastStatusId;
         


            await questionRepository.UpdateAsync(updatequestion, cancellationToken);

            return Ok();
        }

        [HttpDelete]
        public async Task<ApiResult> Delete(int id, CancellationToken cancellationToken)
        {
            var question = await questionRepository.GetByIdAsync(cancellationToken, id);
            await questionRepository.DeleteAsync(question, cancellationToken);

            return Ok();
        }
    }
}
