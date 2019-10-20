using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public struct QuestionAnswersContainer
    {
        public float Expected;
        public bool[] ActualValues;

        public QuestionAnswersContainer(float Expected, params bool[] ActualValues)
        {
            this.Expected = Expected;
            this.ActualValues = ActualValues;
        }
    }
}
