using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WriteFile
    {
        public void WriteToFile()
        {
            string filePath = "C:/Users/USER/Documents/JituTraining/c# practice/WordCount/WordCount/Data/input.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("What is life!");
                    writer.WriteLine("Where do we go from here?");
                    writer.WriteLine("Is this it?");
                    writer.WriteLine("Find out below");
                }

                Console.WriteLine("Text written to file successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}

