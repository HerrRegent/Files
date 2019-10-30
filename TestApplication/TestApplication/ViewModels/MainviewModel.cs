namespace TestApplication.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public ViewModel CurrentPage
        {
            get;
            set;
        }

        public MainViewModel()
        {
            var firstPage = new TestPageViewModel();

            firstPage.OnTestComplete += (result) =>
            {
                var secondPage = new ResultPageViewModel(result);
                CurrentPage = secondPage;
                PropertyChange(nameof(CurrentPage));
            };

            CurrentPage = firstPage;
        }
    }
}