using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vs_project.Models
{
    public class Survey
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> QuestionUsers { get; set; }



        public int? QuestionsListID { get; set; }
        public virtual List<Question> Questions { get; set; }

    }
}