using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
