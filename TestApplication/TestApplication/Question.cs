using System.Linq;
using TestApplication.Service;

namespace TestApplication
{
    [System.Serializable]
    public class Question
    {
        public enum QuestionType
        {
            Standart
        }

        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public Answer[] Answers { get; set; }

        public float GetScore()
        {
            if(Answers.Length == 0)
            {
                return 0;
            }

            int correctCount = Answers.Count(x => x.ActualValue == x.IsCorrect);
            int incorrectCount = Answers.Count(x => x.ActualValue != x.IsCorrect);

            return MathHelper.Clamp((correctCount - incorrectCount) / (float)Answers.Length, 0, 1);
        }
    }
}