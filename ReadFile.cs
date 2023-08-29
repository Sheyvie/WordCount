using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class ReadFile

    {
        public void ContentRead()
        {
            string filePath = "C:/Users/USER/Documents/JituTraining/c# practice/WordCount/WordCount/Data/input.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    int wordCount = CountWords(content);

                    Console.WriteLine("Text content of input.txt:");
                    Console.WriteLine(content);
                    Console.WriteLine();
                    Console.WriteLine($"Total word count: {wordCount}");
                }
                else
                {
                    Console.WriteLine("The input file does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }

            static int CountWords(string text)
            {
                string[] words = text.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }
        }
    }
}


