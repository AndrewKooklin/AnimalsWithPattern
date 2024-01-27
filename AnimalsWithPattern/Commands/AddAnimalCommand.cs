using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class AddAnimalCommand : ICommand
    {

        AnimalsDBEntities _animalsDB;

        public AddAnimalCommand(AnimalsDBEntities animalsDB)
        {
            _animalsDB = animalsDB;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
