using AnimalsWithPattern.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimalsWithPattern.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        AnimalsDBEntities animalsDB = new AnimalsDBEntities();

        public MainWindowViewModel()
        {
            animalsDB.Animals.Load();
            _animalsCollection = new ObservableCollection<Animals>();

            foreach(var animal in animalsDB.Animals)
            {
                _animalsCollection.Add(animal);
            }

            AddAnimalCommand = new AddAnimalCommand(animalsDB);
            OpenAddAnimalWindowCommand = new OpenAddAnimalWindowCommand();
    }

    public ObservableCollection<Animals> _animalsCollection;

        public ObservableCollection<Animals> AnimalsCollection
        {
            get
            {
                return _animalsCollection;
            }
            set
            {
                _animalsCollection = value;
                OnPropertyChanged(nameof(AnimalsCollection));
            }
        }

        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _typeAnimal;

        public string TypeAnimal
        {
            get
            {
                return _typeAnimal;
            }
            set
            {
                _typeAnimal = value;
                OnPropertyChanged(nameof(TypeAnimal));
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _location;

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        private string _feed;

        public string Feed
        {
            get
            {
                return _feed;
            }
            set
            {
                _feed = value;
                OnPropertyChanged(nameof(Feed));
            }
        }

        public ICommand AddAnimalCommand { get; set; }

        public ICommand OpenAddAnimalWindowCommand { get; set; }
    }
}
