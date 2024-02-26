using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.LanguageDictionary
{
    public class LanguageDictionary<T, K>
    {
        public Dictionary<T, K> MyDictionaryObject { get; set; } = [];
        public void CreateAdd(T english, K georgian)
        {
            MyDictionaryObject.Add(english, georgian);
        }
        public List<string> GetDictionaryAsList()
        {
            var list = new List<string>();

            foreach (var language in MyDictionaryObject.Keys)
            {
                // Console.WriteLine($"{language} = {MyDictionaryObject[language]}");
                list.Add(language.ToString() + "=" + MyDictionaryObject[language]);
            }
            return list;
        }
        public void WriteDictionaryToFile()
        {
            using (StreamWriter sw = new StreamWriter(GetFilePath()))
            {
                foreach (var item in GetDictionaryAsList())
                {
                    sw.WriteLine(item);
                }
            }
        }
        public List<string> ReadDictionaryFromFile()
        {
            List<string> wordsFromFile = [];

            using (StreamReader sr = new StreamReader(GetFilePath()))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    //Console.WriteLine(line);
                    wordsFromFile.Add(line);
                }
            }
            return wordsFromFile;
        }

        public string GetFilePath()
        {
            return "example.txt";
        }

    }
}
