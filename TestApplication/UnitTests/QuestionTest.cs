using System.Linq;
using TestApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class QuestionTest
    {
        [TestMethod]
        public void ScoreTest()
        {
            #region Create Examples
            Question test_question = new Question();

            test_question.Answers = new Answer[]
                {
                    new Answer("Answer_0"),
                    new Answer("Answer_0", true),
                    new Answer("Answer_0"),
                    new Answer("Answer_0", true)
                };

            #endregion

            #region Create Containers
            QuestionAnswersContainer[] test_dataset = new QuestionAnswersContainer[]
                {
                    new QuestionAnswersContainer(1F, false, true, false, true),
                    new QuestionAnswersContainer(0F, true, false, true, false),

                    new QuestionAnswersContainer(0.5F, false, true, false, false),
                    new QuestionAnswersContainer(0.5F, false, true, true, true)
                };
            #endregion

            #region Test Examples
            foreach (QuestionAnswersContainer example in test_dataset)
            {
                if(example.ActualValues.Length != test_question.Answers.Length)
                {
                    throw new System.Exception("Invalid dataset");
                }

                for(int i = 0; i < example.ActualValues.Length; i++)
                {
                    test_question.Answers[i].ActualValue = example.ActualValues[i];
                }


                Assert.AreEqual(example.Expected, test_question.GetScore());
            }
            #endregion
        }
    }
}
