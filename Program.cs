//Create a program that reads a text file and counts the number of words in it.
//The program should display the total word count at the end.

using WordCount;

createFile createFile = new createFile();
createFile.createAFile();
WriteFile writeFile = new WriteFile();
writeFile.WriteToFile();
ReadFile readFile = new ReadFile();
readFile.ContentRead();