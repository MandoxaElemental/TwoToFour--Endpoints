using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour__Endpoints.Services
{
    public class Add2NumbersServices
    {
    public List<string> numbers = new();
    public List<string> AddNumbers(int numberOne, int numberTwo){
        numbers.Add(numberOne + " Plus " + numberTwo + " is Euqal to: " + (numberOne+numberTwo) + ". Noice!");
        return numbers;
    }
    }
}