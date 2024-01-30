using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class AddAnimalCommand : ICommand
    {
        ObservableCollection<Animals> _animalsCollection;
        HelpMethods helpMethods = new HelpMethods();
        AnimalFactory animalFactory = new AnimalFactory();
        ComboBox cbTypeAnimal;
        TextBox tbName;
        TextBox tbLocal;
        TextBox tbFeed;
        ModelAnimal _animalsDB;

        public AddAnimalCommand(ModelAnimal animalsDB, ObservableCollection<Animals> animalsCollection)
        {
            _animalsDB = animalsDB;
            _animalsCollection = animalsCollection;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(parameter is Grid)
            {
                Grid gridAnimal = (Grid)parameter;
                var gridChildren = gridAnimal.Children;
                cbTypeAnimal = (ComboBox)gridChildren[6];
                Label lErrorTypeAnimal = (Label)gridChildren[7];
                tbName = (TextBox)gridChildren[8];
                Label lErrorName = (Label)gridChildren[9];
                tbLocal = (TextBox)gridChildren[10];
                Label lErrorLocal = (Label)gridChildren[11];
                tbFeed = (TextBox)gridChildren[12];

                if(cbTypeAnimal.SelectedItem == null)
                {
                    lErrorTypeAnimal.Content = "Выберите тип животного";
                    return false;
                }
                else
                {
                    lErrorTypeAnimal.Content = "";
                }
                if(String.IsNullOrEmpty(tbName.Text) || !helpMethods.CheckInputString(tbName.Text))
                {
                    lErrorName.Content = "Наименование не менее 3 букв";
                    return false;
                }
                else
                {
                    lErrorName.Content = "";
                }
                if(String.IsNullOrEmpty(tbLocal.Text) || !helpMethods.CheckInputString(tbLocal.Text))
                {
                    lErrorLocal.Content = "Среда обитания не менее 3 букв";
                    return false;
                }
                else
                {
                    lErrorLocal.Content = "";
                }
            }
            return true;
        }

        public void Execute(object parameter)
        {
            object iAnimal = animalFactory.GetAnimal(cbTypeAnimal.SelectedItem.ToString(),
                                                     tbName.Text, tbLocal.Text, tbFeed.Text);
            iAnimal = new Animals(cbTypeAnimal.SelectedItem.ToString(),
                                                     tbName.Text, tbLocal.Text, tbFeed.Text);

            _animalsCollection.Add((Animals)iAnimal);
            _animalsDB.Animals.Add((Animals)iAnimal);
            _animalsDB.SaveChanges();

            ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = null;
            ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = _animalsCollection;
        }
    }
}
