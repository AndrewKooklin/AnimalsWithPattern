using AnimalsWithPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class OpenChangeAnimalWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        ListView listAnimals;
        int indexSelectedAnimalType;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ListView)
            {
                listAnimals = (ListView)parameter;
                if(listAnimals.SelectedIndex == -1 || listAnimals.Items.Count == 0)
                {
                    MessageBox.Show("Выберите животное","Выбор животного", 
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else
                {
                    Animals animal = (Animals)listAnimals.SelectedItem;
                    AddAnimalWindow addAnimalWindow = new AddAnimalWindow();
                    string type = animal.TypeAnimal.ToString();
                    switch (type)
                    {
                        case "Mammals":
                            {
                                indexSelectedAnimalType = 0;
                                break;
                            }
                        case "Birds":
                            {
                                indexSelectedAnimalType = 1;
                                break;
                            }
                        case "Amphibians":
                            {
                                indexSelectedAnimalType = 2;
                                break;
                            }
                        default:
                            {
                                indexSelectedAnimalType = 3;
                                break;
                            }
                    }
                    
                    addAnimalWindow.cbTypeAnimal.SelectedIndex = indexSelectedAnimalType;
                    addAnimalWindow.lAnimalId.Content = animal.AnimalId.ToString();
                    addAnimalWindow.tbName.Text = animal.Name.ToString();
                    addAnimalWindow.tbLocation.Text = animal.Location.ToString();
                    addAnimalWindow.tbFeed.Text = animal.Feed.ToString();
                    addAnimalWindow.Show();
                }
            }
        }
    }
}
