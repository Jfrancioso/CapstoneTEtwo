using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenmoServer.DAO;

namespace TenmoServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransferController : ControllerBase
    {
        private readonly IAccountDao accountDao;

        public TransferController(IAccountDao _accountDao)
        {
            accountDao = _accountDao;
        }


    }
}
