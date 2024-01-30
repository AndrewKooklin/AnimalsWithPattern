using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class ClearAddAnimalFormCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is Grid)
            {
                Grid gridAnimal = (Grid)parameter;
                var gridChildren = gridAnimal.Children;
                Label lErrorTypeAnimal = (Label)gridChildren[7];
                TextBox tbName = (TextBox)gridChildren[8];
                Label lErrorName = (Label)gridChildren[9];
                TextBox tbLocal = (TextBox)gridChildren[10];
                Label lErrorLocal = (Label)gridChildren[11];
                TextBox tbFeed = (TextBox)gridChildren[12];

                lErrorTypeAnimal.Content = "";
                tbName.Text = "";
                lErrorName.Content = "";
                tbLocal.Text = "";
                lErrorLocal.Content = "";
                tbFeed.Text = "";
            }
        }
    }
}
