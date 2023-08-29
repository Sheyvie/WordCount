using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class createFile
    {
        public void createAFile()
        {
            string filePath = "C:/Users/USER/Documents/JituTraining/c# practice/WordCount/WordCount/Data/input.txt";


            try
            {
                using (FileStream fs = File.Create(filePath))
                {
                    // File creation code here
                    byte[] data = System.Text.Encoding.UTF8.GetBytes("This is a newly created file.");
                    fs.Write(data, 0, data.Length);
                }

                Console.WriteLine("File created successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while creating the file: " + ex.Message);
            }

            FileInfo fileInfo = new FileInfo(filePath);
            DateTime creationTime = fileInfo.CreationTime;
            DateTime lastWriteTime = fileInfo.LastWriteTime;
            Console.WriteLine($"creation time :{fileInfo.CreationTime}");
            Console.WriteLine($"last write time :{fileInfo.LastWriteTime}");

            FileInfo fileInfo2 = new FileInfo(filePath);
            long fileSize = fileInfo2.Length;
            Console.WriteLine($"file length is :{fileInfo2.Length}");




        }

    }
}
