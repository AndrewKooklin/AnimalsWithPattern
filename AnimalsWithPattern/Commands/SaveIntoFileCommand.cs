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
    public class SaveIntoFileCommand : ICommand
    {
        ModelAnimal _animalsDB;

        public event EventHandler CanExecuteChanged;

        public SaveIntoFileCommand(ModelAnimal animalsDB)
        {
            _animalsDB = animalsDB;
        }
        

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            FileWriter fw;
            var saveToXML = new SaveToXML("AnimalsXML");
            var saveToJSON = new SaveToJSON("AnimalsJSON");
            ComboBox cbFormat = (ComboBox)parameter;
            string cbFormatValue = cbFormat.SelectedItem.ToString();

            switch (cbFormatValue)
            {
                case "XML":
                    {
                        fw = new FileWriter(saveToXML, _animalsDB);
                        fw.Save();
                        break;
                    }
                case "JSON":
                    {
                        fw = new FileWriter(saveToJSON, _animalsDB);
                        fw.Save();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Выберите формат файла", "Выбор формата", 
                                         MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    }
            }
        }
    }
}
