using System;
using System.Collections.Generic;
using System.IO;

namespace TestApplication
{
    public static class QuestionDataBase
    {
        private const string QuestionDirectory = @"Questions";

        public static void CreateTemplate()
        {
            if (!Directory.Exists(QuestionDirectory))
                Directory.CreateDirectory(QuestionDirectory);

            Question questionTemplate = new Question()
            {
                Text = "Деятельность человека",

                Answers = new Answer[]
                {
                    new Answer("Проф"),
                    new Answer("Инф", true),
                    new Answer("Труд"),
                    new Answer("Позн")
                }
            };

            Serializator.Serialization(Path.Combine(QuestionDirectory, "template.xml"), questionTemplate);
        }

        public static List<Question> GetQuestions()
        {
            if (!Directory.Exists(QuestionDirectory))
                Directory.CreateDirectory(QuestionDirectory);

            List<Question> questions = new List<Question>();
            DirectoryInfo directory = new DirectoryInfo(QuestionDirectory);

            foreach(var file in directory.GetFiles("*.xml"))
            {
                Question question = Serializator.Deserialization<Question>(file.FullName);

                if (question != null)
                    questions.Add(question);
            }

            return questions;
        }
    }
}
