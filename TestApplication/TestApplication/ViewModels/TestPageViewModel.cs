using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace TestApplication.ViewModels
{
    public class TestPageViewModel : ViewModel
    {
        public event System.Action<float> OnTestComplete;

        public ObservableCollection<Question> Questions
        {
            get;
            set;
        }

        public ICommand CompleteTestCommand
        {
            get;
            set;
        }

        public TestPageViewModel()
        {
            var relayCommand = new RelayCommand(CompleteTest, CheckTest);
            CompleteTestCommand = relayCommand;

            Questions = new ObservableCollection<Question>(QuestionDataBase.GetQuestions());
            Questions.CollectionChanged += (send, e) =>
            {
                PropertyChange(nameof(Questions));
            };
        }

        private bool CheckTest()
        {
            return true;
        }

        private void CompleteTest()
        {
            float result = Questions.Sum(x => x.GetScore());

            OnTestComplete?.Invoke(result);
        }
    }
}