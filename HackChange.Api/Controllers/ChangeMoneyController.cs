using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HackChange.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeMoneyController : ControllerBase
    {
        // GET api/values
        [HttpGet("{amount}/{pay}")]
        public ActionResult<ChangeModel> Get(int amount, int pay)
        {
            var hackChangeMoney = new HackChangeMoney();
            var result = hackChangeMoney.CalculateChange(amount, pay);
            return result;
        }
    }
}
