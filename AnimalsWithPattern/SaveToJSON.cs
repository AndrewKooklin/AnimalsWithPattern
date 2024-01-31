using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace AnimalsWithPattern
{
    public class SaveToJSON : IFileSave
    {
        private string _nameFile;
        List<Animals> _animals = new List<Animals>();

        public SaveToJSON(string nameFile)
        {
            _nameFile = nameFile;
        }

        public void SaveToFile(ModelAnimal _animalsDB)
        {
            if (_animalsDB.Animals.Local.Count >= 0)
            {
                _animals = _animalsDB.Animals.ToList<Animals>();

                using (FileStream fs = new FileStream(_nameFile, FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize(fs, _animals);
                }
                MessageBox.Show("База сохранена \nв формате JSON", "Сохранение", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
