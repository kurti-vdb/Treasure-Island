using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vs_project.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }


        //public int SurveyID { get; set; }
        //public virtual Survey Survey { get; set; }

        public virtual List<Answer> Answers { get; set; }
    }
}