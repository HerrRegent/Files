using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace TestApplication.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Question> Questions
        {
            get;
            set;
        }

        public MainViewModel()
        {
            Questions = new ObservableCollection<Question>(QuestionDataBase.GetQuestions());
            Questions.CollectionChanged += (send, e) =>
            {
                PropertyChange(nameof(Questions));
            };
        }

        public void PropertyChange(string propertyName)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, args);
        }
    }
}
