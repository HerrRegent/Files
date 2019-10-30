namespace TestApplication.ViewModels
{
    public class ResultPageViewModel : ViewModel
    {
        public int Result
        {
            get => (int)result;
        }

        private float result;

        public ResultPageViewModel(float result)
        {
            this.result = result;
        }
    }
}