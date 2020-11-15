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
        public ActionResult<IEnumerable<int>> CalcResultRegister(string strCalcResult)
        {
            int calcResult = int.Parse(strCalcResult);

            calcResult += 100;

            return new int[] { calcResult };
        }

        [HttpGet]
        public ActionResult<IEnumerable<int>> Index()
        {
            DB_houseCalc dbHouseCalc = new DB_houseCalc();
            dbHouseCalc.InsResultCalc();



            return new int[] { 0 };
        }
    }
}