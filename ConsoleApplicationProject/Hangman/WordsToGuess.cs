using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.Hangman
{
    public class WordsToGuess
    {
        public List<string> Words {  get; set; } = new List<string>();

        public WordsToGuess() 
        {
            Words.Add("Gamarjoba");
            Words.Add("Programireba");
            Words.Add("Gamarjoba");
        }


        public int LengthOfTheWordsList()
        { 
            return Words.Count; 
        }

        public string GetWord(int Index)
        {

            return Words[Index].ToLower();
        }
    }
}
