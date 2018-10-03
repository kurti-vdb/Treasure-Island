using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vs_project.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }
    }
}