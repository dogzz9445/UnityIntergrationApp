using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UnityIntergrationApp.Common
{
    public class ActionCommand : ICommand
    {
        private readonly Action m_execute;
        private readonly Func<bool> m_canExecute;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return m_canExecute == null ? true : m_canExecute();
        }

        public void Execute(object parameter)
        {
            m_execute();
        }

        public ActionCommand(Action execute) : this(execute, null)
        {
        }

        public ActionCommand(Action execute, Func<bool> canExecute)
        {
            m_execute = execute ?? throw new ArgumentNullException("execute");
            m_canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
