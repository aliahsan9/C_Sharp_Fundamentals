using System;

class ExceptionsDemo
{
    static void Main()
    {
    string fileName = "WrongTextFile.txt";
    ReadFile(fileName);
    }
    static void ReadFile(string fileName)
  {
    TextReader reader = new StreamReader(fileName);
    string line = reader.ReadLine();
    Console.WriteLine(line);
    reader.Close();
}
}