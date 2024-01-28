using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class HelpMethods
    {
        public bool CheckInputString(string text)
        {
            if (Regex.IsMatch(text, "^[0-9a-zA-Z]{3,}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
