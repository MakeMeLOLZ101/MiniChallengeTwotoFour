using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwotoFour.Services;

namespace MiniChallengeTwotoFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerQuestionsController : ControllerBase
    {
        
        [HttpGet]  // First Question
        public string GetQuestion()
        {
            return "What is your name?";
        }

        [HttpGet]
        public string SecondQuestion()
        {
            return "What is your favorite color?";
        }

        [HttpGet("{name}")] // Second request handler
        public string GetGreeting(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Please provide a name!";
            }

        }

        [HttpGet("{color}")]
        public string GetColor(string color)
        {
            if(string.IsNullOrEmpty(color))
            {
                return "Please give a color or I toss you into the bottomless pit!";
            }

            return $"Hello, you {color} {name}!";
        }
    }
}