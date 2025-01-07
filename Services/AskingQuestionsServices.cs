using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AskingQuestions.Services
{
    public class AskingQuestionsServices
    {
        public List<string> questionList = new ();
        public AskingQuestionsServices(){

        }
        public List<string> AddToQuestionList(string name, int time){
            if (time > 12 || time == 0){
                questionList.Add("Please Enter a Valid Hour");
            }
            else{
                questionList.Add($"Good Morning {name}! Today you have woken up around {time}:00");
            }
            return questionList;
        }
    }
}