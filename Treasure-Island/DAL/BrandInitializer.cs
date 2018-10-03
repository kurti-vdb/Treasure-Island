using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using vs_project.Models;

namespace vs_project.DAL
{

    public class BrandInitializer : DropCreateDatabaseIfModelChanges<BrandContext>
    //public class BrandInitializer : DropCreateDatabaseAlways<BrandContext>
    {
        protected override void Seed(BrandContext context)
        {

            var promos = new List<Promo>
            {
                new Promo { Code = "PROMO" }
            };
            promos.ForEach(p => context.Promos.Add(p));
            context.SaveChanges();


            var titles = new List<Title>
            {
                new Title { Name = " Meneer" },
                new Title { Name = " Mevrouw" }
            };
            titles.ForEach(t => context.Titles.Add(t));
            context.SaveChanges();


            var stores = new List<Store>
            {
                new Store { Name = "Brand.be" },
                new Store { Name = "Brand Antwerpen" },
                new Store { Name = "Brand Mechelen" }
            };
            stores.ForEach(s => context.Stores.Add(s));
            context.SaveChanges();

            var surveys = new List<Survey>
            {
                new Survey { Name = "Brand", QuestionsListID = 1 }
            };
            surveys.ForEach(s => context.Surveys.Add(s));
            context.SaveChanges();


            var questions = new List<Question>
            {
                new Question {
                    Text = "Herken je een van deze helden of piraten?",
                    Answers = new List<Answer>
                    {
                        new Answer { Text = "Will Turner", QuestionID = 1 },
                        new Answer { Text = "Davy Jones", QuestionID = 1 },
                        new Answer { Text = "Hector Barbossa", QuestionID = 1 }
                    }       
                },
                new Question {
                    Text = "Herken je een van deze helden of piraten?",
                    Answers = new List<Answer>
                    {
                        new Answer { Text = "Angelica Teach", QuestionID = 2 },
                        new Answer { Text = "Anamaria III", QuestionID = 2 },
                        new Answer { Text = "Elisabeth Swann", QuestionID = 2 }
                    }
                },
                new Question {
                    Text = "Herken je een van deze helden of piraten?",
                    Answers = new List<Answer>
                    {
                        new Answer { Text = "Jack Sparrow", QuestionID = 3 },
                        new Answer { Text = "Han Solo", QuestionID = 3 },
                        new Answer { Text = "Governor Swann", QuestionID = 3 }
                    }
                }
            };
            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();

        }
    }
}