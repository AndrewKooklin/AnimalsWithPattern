using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace AnimalsWithPattern
{
    public class SaveToXML : IFileSave
    {
        private string _nameFile;

        List<Animals> _animals = new List<Animals>();

        public SaveToXML(string nameFile)
        {
            _nameFile = nameFile;
        }

        public void SaveToFile(ModelAnimal _animalsDB)
        {
            if(_animalsDB.Animals.Local.Count >= 0)
            {
                _animals = _animalsDB.Animals.ToList<Animals>();

                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<Animals>));

                using (FileStream fs = new FileStream(_nameFile, FileMode.OpenOrCreate))
                {
                    xmlFormatter.Serialize(fs, _animals);
                }
                MessageBox.Show("База сохранена \nв формате XML","Сохранение", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
