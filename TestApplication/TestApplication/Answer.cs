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