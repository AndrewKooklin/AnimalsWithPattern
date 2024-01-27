using AnimalsWithPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class OpenAddAnimalWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddAnimalWindow addAnimalWindow = new AddAnimalWindow();
            addAnimalWindow.Show();
        }
    }
}
