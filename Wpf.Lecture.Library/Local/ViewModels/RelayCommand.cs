using System;
using System.Windows.Input;

namespace Wpf.Lecture.Library.Local.ViewModels;
public class RelayCommand : ICommand
{
    private Action _execute;

    public event EventHandler CanExcuteChanged;
    public event EventHandler CanExecuteChanged;

    public RelayCommand(Action execute)
	{
        _execute = execute;
	}

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        _execute.Invoke();
    }
}