using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AskingQuestions.Services;

namespace AskingQuestions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestions : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;

        public AskingQuestions(AskingQuestionsServices askingQuestionsServices){
            _askingQuestionsServices = askingQuestionsServices;
        }
        [HttpPost]
        [Route("AskingQuestions/{name}/{time}")]
        public List<string> AddToQuestionList(string name, int time){
            return _askingQuestionsServices.AddToQuestionList(name, time);
        }
    }
}