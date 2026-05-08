using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class FilesManipulation
    {
        public static void FilesManipulationMethod(string filePath)
        {
            try
            {
                var fileContent = File.ReadAllText(filePath);

                var words = fileContent.Split(' ')
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrEmpty(s));
                Console.WriteLine("Words count: " + words.Count());

                var longestWord = "";

                foreach (var word in words)
                {
                    if (word.Length > longestWord.Length)
                        longestWord = word;
                }

                Console.WriteLine("Display the longest word in the file: " + longestWord);
                Console.WriteLine("Longest word characters amount: " + longestWord.Length);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
