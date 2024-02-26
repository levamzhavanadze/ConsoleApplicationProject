using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.LanguageDictionary
{
    internal class LanguageUI
    {
        public void LanguageDictionary()
        {
            LanguageDictionary<string, string> languageDictionary = new LanguageDictionary<string, string>();

            languageDictionary.CreateAdd("hello", "gamarjoba");
            languageDictionary.CreateAdd("Good buy", "Naxvamdis");

            languageDictionary.WriteDictionaryToFile();

            var i = languageDictionary.ReadDictionaryFromFile();

            foreach (var key in i)
            {
                var DicArray = key.ToString().Split("=");

                for (int j = 0; j < DicArray.Length; j++)
                {
                    Console.WriteLine(DicArray[j]);
                }
            }
        }
    }
}
