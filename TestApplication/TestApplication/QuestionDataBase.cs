using System.Collections.Generic;
using System.IO;

namespace TestApplication
{
    public static class QuestionDataBase
    {
        private const string QuestionDirectory = @"Questions";

        public static List<Question> GetQuestions()
        {
            if (!Directory.Exists(QuestionDirectory))
                Directory.CreateDirectory(QuestionDirectory);

            List<Question> questions = new List<Question>();
            DirectoryInfo directory = new DirectoryInfo(QuestionDirectory);

            foreach (var file in directory.GetFiles("*.xml"))
            {
                Question question = Serializator.Deserialization<Question>(file.FullName);

                if (question != null)
                    questions.Add(question);
            }

            return questions;
        }
    }
}