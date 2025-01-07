using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreaterThanOrLessThan.Services
{
    public class GreaterThanOrLessThanServices
    {
        public List<string> comparisonList = new ();
        public GreaterThanOrLessThanServices()
        {
            
        }
        [HttpPost]
        [Route("comparison/{firstNum}/{secondNum}")]
        public List<string> UpdateComparison(int firstNum, int secondNum){
            if (firstNum > secondNum){
                comparisonList.Add($"{firstNum} is Greater than {secondNum}");
                comparisonList.Add($"{secondNum} is Less than {firstNum}");
            } else if (firstNum < secondNum){
                comparisonList.Add($"{firstNum} is Less than {secondNum}");
                comparisonList.Add($"{secondNum} is Greater than {firstNum}");
            } else {
                comparisonList.Add($"{firstNum} is Equal to {secondNum}");
                comparisonList.Add($"{secondNum} is Equal to {firstNum}");
            }
                return comparisonList;
        }
    }
}