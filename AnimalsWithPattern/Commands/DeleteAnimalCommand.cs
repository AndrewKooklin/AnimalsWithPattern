using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class DeleteAnimalCommand : ICommand
    {
        ModelAnimal _animalsDB;
        ObservableCollection<Animals> _animalsCollection;

        public DeleteAnimalCommand(ModelAnimal animalsDB, ObservableCollection<Animals> animalsCollection)
        {
            _animalsDB = animalsDB;
            _animalsCollection = animalsCollection;
        }

        public event EventHandler CanExecuteChanged;
        ListView listAnimals;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ListView)
            {
                listAnimals = (ListView)parameter;
                if (listAnimals.SelectedIndex == -1 || listAnimals.Items.Count == 0)
                {
                    MessageBox.Show("Выберите животного", "Выбор животного", MessageBoxButton.OK,
                                        MessageBoxImage.Warning);
                    return;
                }
                else
                {
                    Animals animal = (Animals)listAnimals.SelectedItem;
                    _animalsDB.Animals.Remove(animal);
                    _animalsCollection.Remove(animal);
                    _animalsDB.SaveChanges();

                    ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = null;
                    ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = _animalsCollection;
                }
            }
            else return;
        }
    }
}
