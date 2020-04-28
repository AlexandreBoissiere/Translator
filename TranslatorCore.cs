using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenchImplelentation;

namespace TranslatorCore
{
    public class Core
    {
        public Core(string text, string inputLanguage, string outputLangage, out string output)
        {
            string inLang = "";
            if (inputLanguage == "Latin")
            {
                inLang = "latin";
            }
            else
            {
                throw new Exception("Unknown input language !");
            }

            if (outputLangage == "Français")
            {
                output = French.ToFrench(text, inLang);
                return;
            }
            throw new Exception("Unknown output language !");
        }
    }
}
