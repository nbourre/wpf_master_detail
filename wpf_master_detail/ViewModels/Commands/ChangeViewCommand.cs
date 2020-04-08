using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace wpf_master_detail.ViewModels.Commands
{
    class ChangeViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<string> _execute;

        public ChangeViewCommand(Action<string> action)
        {
            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as string);
        }
    }
}
