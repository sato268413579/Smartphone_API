using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Smartphone_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcRegistController : Controller
    {
        [HttpPost]
        public ActionResult<IEnumerable<int>> CalcResultRegister([FromBody]string strCalcResult, string test)
        {
            int calcResult = int.Parse(strCalcResult);

            calcResult += 100;

            return new int[] { calcResult };
        }

        [HttpGet]
        public ActionResult<IEnumerable<int>> Index()
        {
            return new int[] { 0 };
        }
    }
}