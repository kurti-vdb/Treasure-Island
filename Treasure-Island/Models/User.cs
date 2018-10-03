using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vs_project.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set;}
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string KeepMeInformed { get; set; }
        public string Agreed { get; set; }


        public string Title { get; set; }
        public string Store { get; set; }
        public string Answer { get; set; }



        //public bool KeepMeInformed { get; set; }
        //public bool Agreed { get; set; }

        //public int TitleID { get; set; }
        //public virtual Title Title { get; set; }

        //public int StoreID { get; set; }
        //public virtual Store Store { get; set; } 

        //public int SurveyID { get; set; }
        //public virtual Survey Survey { get; set; }
    }
}