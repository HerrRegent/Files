using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    [System.Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public bool ActualValue { get; set; }

        public Answer()
        {

        }

        public Answer(string Text, bool IsCorrect = false)
        {
            this.Text = Text;
            this.IsCorrect = IsCorrect;
        }
    }
}
