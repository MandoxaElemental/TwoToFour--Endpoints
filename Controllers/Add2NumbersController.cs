using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFour__Endpoints.Services;

namespace TwoToFour__Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2Numbers : ControllerBase
    {
        private readonly Add2NumbersServices _add2NumbersServices;
        public Add2Numbers(Add2NumbersServices add2NumbersServices){
            _add2NumbersServices = add2NumbersServices;
        }
        [HttpPost]
        [Route("addNumber/{numberOne}/{numberTwo}")]
        public List<string> AddNumbers(int numberOne, int numberTwo){
        return _add2NumbersServices.AddNumbers(numberOne, numberTwo);
    }
    }
}