﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1_Questionnaire
{
    class Question
    {
        public static XElement xdoc = XElement.Load("..\\..\\questions.xml");
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string GoodAnswer { get; set; }
        public string Image { get; set; }


        public Question(int id)
        {
            Id = id;
            CreateQuestion(id);
        }


        // Cette fonction permet de créer une question à partir du fichier XML et de l'id de la question
        private void CreateQuestion(int id)
        {
            //Lecture du xml
            var items = from item in xdoc.Descendants("Question")
                        where item.Attribute("Id").Value == id.ToString()
                        select new
                        {
                            QuestionText = item.Element("QuestionText").Value,
                            Answers = item.Descendants("Answers").Descendants().Select(x => x.Value).ToList(),
                            GoodAnswer = item.Element("GoodAnswer").Value,
                            Image = item.Element("Image").Value,
                        };

            //On entre les valeurs dans la question
            foreach (var item in items)
            {
                this.QuestionText = item.QuestionText;
                this.Answers = item.Answers;
                this.GoodAnswer = item.GoodAnswer;
                this.Image = item.Image;
            }

            return;
        }


    }
}
