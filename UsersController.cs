using Microsoft.AspNetCore.Mvc;
using TinderApplication.Models;
using TinderApplication.Repository;

namespace TinderApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUsersRepository _usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        [HttpPost]
        public IActionResult AddDataInUsers (UsersModel usersModel)
        {
            var result = _usersRepository.AddDataInUsers(usersModel);

            return Ok(result);


        }


        [HttpDelete]
        public IActionResult DeleteById(int  userid)
        {
            var result = _usersRepository.DeleteById(userid);

            return Ok(result);


        }



        [HttpPost("memberships")]
        public IActionResult AddDataInMemberships(MembershipModel membershipModel)
        {
            var result = _usersRepository.AddDataInMemberships(membershipModel);

            return Ok(result);


        }


        [HttpDelete("memberships")]
        public IActionResult DeleteDataInMemberships(string membershiptype)
        {
            var result = _usersRepository.DeleteDataInMemberships(membershiptype);

            return Ok(result);

        }


            [HttpPost("matches")]
            public IActionResult AddDataInMatches(MatchesModel matchesModel)
            {
                var result = _usersRepository.AddDataInMatches(matchesModel);

                return Ok(result);


            }

        [HttpGet("GetUserMembership")]
        public IActionResult GetUserMembership(int userId)
        {
            var result = _usersRepository.GetUserMembership(userId);

            return Ok(result);


        }

        [HttpGet("GetDatafromUser")]
        public IActionResult GetDataFromUser(int userId)
        {
            var result = _usersRepository.GetDataFromUser(userId);

            return Ok(result);


        }

        [HttpGet("GetPremiumUsers")]
        public IActionResult GetPremiumUsers(string membershiptype)
        {
            var result = _usersRepository.GetPremiumUsers(membershiptype);

            return Ok(result);


        }

        
    }
    }


