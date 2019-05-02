using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
      
        // GET api/values/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public ActionResult Sum(string firstNumber, string secondNumber)
        {
            if(isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private int ConvertToDecimal(string firstNumber)
        {
            throw new NotImplementedException();
        }

        private bool isNumeric(string secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}
