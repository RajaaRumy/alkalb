using System;

namespace alkalb.Command
{
    public abstract class RelaycommandBase
    {
        private Action DoWork;

        public abstract event EventHandler CanExecuteChanged;

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }
}