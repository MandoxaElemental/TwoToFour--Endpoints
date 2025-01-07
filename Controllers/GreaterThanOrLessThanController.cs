using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreaterThanOrLessThan.Services;

namespace GreaterThanOrLessThan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThanOrLessThan : ControllerBase
    {
        private readonly GreaterThanOrLessThanServices _greaterThanOrLessThanServices;
        public GreaterThanOrLessThan(GreaterThanOrLessThanServices greaterThanOrLessThanServices){
            _greaterThanOrLessThanServices = greaterThanOrLessThanServices;
        }
        [HttpPost]
        [Route("comparison/{firstNum}/{secondNum}")]
        public List<string> UpdateComparison(int firstNum, int secondNum){
            return _greaterThanOrLessThanServices.UpdateComparison(firstNum, secondNum);
        }
    }
}