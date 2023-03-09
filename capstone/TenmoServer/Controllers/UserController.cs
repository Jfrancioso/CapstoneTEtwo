using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using TenmoServer.DAO;
using TenmoServer.Models;

namespace TenmoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserDao userDao;
        public UserController(IUserDao _userDao) 
        {
            userDao = _userDao;
        }

        [HttpGet]
        public IList<User> GetUsers()
        {
            return userDao.GetUsers();
        }
    }
}
