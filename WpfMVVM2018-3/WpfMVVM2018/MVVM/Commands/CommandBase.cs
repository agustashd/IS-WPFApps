using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMVVM2018.MVVM.Commands
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public CommandBase(Func<object, Task> target)
        {
            thefunction = target;
        }

        /// <summary>
        /// Variable que hace referencia a la función/tarea que 
        /// realmente se quiere ejecutar
        /// </summary>
        private Func<object, Task> thefunction;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            thefunction(parameter);
        }
    }
}
