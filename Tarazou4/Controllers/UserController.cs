using Common.Exceptions;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;
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
    public class UserController : ControllerBase
    {

        private readonly IUserRepository userRepository;
        private readonly IJwtService jwtService;


        public UserController(IUserRepository userRepository, IJwtService jwtService)
        {
            this.userRepository = userRepository;
            this.jwtService = jwtService;



        }
        [HttpGet("[action]")]
        public async Task <string> token(string username,string password, CancellationToken cancellationToken)
        {

        var user=  await  userRepository.GetByUserAndPass(username,password, cancellationToken);
            if (user==null)
            
                throw new BadRequestException("تام کاربززس اشتلاهه است");

           var jwt= jwtService.Generate(user);
            return jwt;







        }
        [HttpGet]
      [Authorize]

        public async Task<ActionResult<List<User>>> Get(CancellationToken cancellationToken)
        {
            var users = await userRepository.TableNoTracking.ToListAsync(cancellationToken);
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<ApiResult<User>> Get(int id, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(cancellationToken, id);
            if (user == null)
                return NotFound();
            return user;
        }
      
       // [Authorize]
        [HttpPost]



        public async Task<ApiResult<User>> Create(User userDto, CancellationToken cancellationToken)
        {
            //var exists = await userRepository.TableNoTracking.AnyAsync(p => p.UserName == userDto.UserName);
            //if (exists)
            //    return BadRequest("نام کاربری تکراری است")

            var user = new User
            {
                Guid = userDto.Guid,
                Username = userDto.Username,
                FirstName = userDto.FirstName,
                Mobile = userDto.Mobile,
                MobileVerificationCode = userDto.MobileVerificationCode,
                LastName = userDto.LastName,
                Password = userDto.Password,
                PasswordSalt = userDto.PasswordSalt,
                ProvinceId = userDto.ProvinceId,
                IsVerify = userDto.IsVerify,
                Credit = userDto.Credit,
                CreatedOnUtc = userDto.CreatedOnUtc,
                Active = userDto.Active
            };
            await userRepository.AddAsync(user, userDto.Password, cancellationToken);
            return user;
        }

        [HttpPut]
        public async Task<ApiResult> Update(int id, User user, CancellationToken cancellationToken)
        {
            var updateUser = await userRepository.GetByIdAsync(cancellationToken, id);

            updateUser.FirstName = user.FirstName;
            updateUser.Mobile = user.Mobile;
            updateUser.LastName = user.LastName;
            updateUser.Password = user.Password;
            updateUser.ProvinceId = user.ProvinceId;
            updateUser.IsVerify = user.IsVerify;
            updateUser.LastLoginDate = user.LastLoginDate;
            updateUser.Credit = user.Credit;
            updateUser.CreatedOnUtc = user.CreatedOnUtc;
            updateUser.Active = user.Active;


            await userRepository.UpdateAsync(updateUser, cancellationToken);

            return Ok();
        }

        [HttpDelete]
        public async Task<ApiResult> Delete(int id, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(cancellationToken, id);
            await userRepository.DeleteAsync(user, cancellationToken);

            return Ok();
        }
    }
}