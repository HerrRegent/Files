using System;
using System.Windows.Input;

namespace TestApplication
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Func<bool> canExecute;
        private Action action;

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }
    }
}