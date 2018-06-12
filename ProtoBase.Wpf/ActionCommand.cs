using System;
using System.Windows.Input;

namespace ProtoBase.Wpf
{
    public class ActionCommand : ICommand
    {
        #region Events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Fields

        private readonly Action _action;
        private readonly Func<object, bool> _canExecute;

        #endregion

        #region Constructors

        public ActionCommand(Action action)
        {
            _action = action;
            _canExecute = _ => true;
        }

        public ActionCommand(Action action, Func<object, bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        #endregion

        #region Public Methods

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }

        #endregion
    }
}
