using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimalsWithPattern.Commands
{
    public class ChangeAnimalCommand : ICommand
    {
        ObservableCollection<Animals> _animalsCollection;
        HelpMethods helpMethods = new HelpMethods();
        AnimalFactory animalFactory = new AnimalFactory();
        Animals animalFromCollection;
        Animals animalFromDB;
        int animalId;
        Label lAnimalId;
        ComboBox cbTypeAnimal;
        TextBox tbName;
        TextBox tbLocation;
        TextBox tbFeed;
        ModelAnimal _animalsDB;
        public event EventHandler CanExecuteChanged;

        public ChangeAnimalCommand(ModelAnimal animalsDB, ObservableCollection<Animals> animalsCollection)
        {
            _animalsDB = animalsDB;
            _animalsCollection = animalsCollection;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter is Grid)
            {
                Grid gridAnimal = (Grid)parameter;
                var gridChildren = gridAnimal.Children;
                lAnimalId = (Label)gridChildren[1];
                animalId = Convert.ToInt32(lAnimalId.Content.ToString());
                cbTypeAnimal = (ComboBox)gridChildren[6];
                Label lErrorTypeAnimal = (Label)gridChildren[7];
                tbName = (TextBox)gridChildren[8];
                Label lErrorName = (Label)gridChildren[9];
                tbLocation = (TextBox)gridChildren[10];
                Label lErrorLocal = (Label)gridChildren[11];
                tbFeed = (TextBox)gridChildren[12];

                if (cbTypeAnimal.SelectedItem == null)
                {
                    lErrorTypeAnimal.Content = "Выберите тип животного";
                    return false;
                }
                else
                {
                    lErrorTypeAnimal.Content = "";
                }
                if (String.IsNullOrEmpty(tbName.Text) || !helpMethods.CheckInputString(tbName.Text))
                {
                    lErrorName.Content = "Наименование не менее 3 букв";
                    return false;
                }
                else
                {
                    lErrorName.Content = "";
                }
                if (String.IsNullOrEmpty(tbLocation.Text) || !helpMethods.CheckInputString(tbLocation.Text))
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
            animalFromCollection = _animalsCollection.First(a => a.AnimalId == animalId);

            animalFromDB = _animalsCollection.First(a => a.AnimalId == animalId);

            animalFromCollection.TypeAnimal = cbTypeAnimal.SelectedItem.ToString();
            animalFromCollection.Name = tbName.Text.ToString();
            animalFromCollection.Location = tbLocation.Text.ToString();
            animalFromCollection.Feed = tbFeed.Text.ToString();

            animalFromDB.TypeAnimal = cbTypeAnimal.SelectedItem.ToString();
            animalFromDB.Name = tbName.Text.ToString();
            animalFromDB.Location = tbLocation.Text.ToString();
            animalFromDB.Feed = tbFeed.Text.ToString();

            _animalsDB.SaveChanges();

            ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = null;
            ((MainWindow)System.Windows.Application.Current.MainWindow).lvAnimals.ItemsSource = _animalsCollection;
        }
    }
}
