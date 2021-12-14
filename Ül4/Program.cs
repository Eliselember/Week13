using System;
using System.IO;
namespace Ül4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = $@"C:\Users\opilane\samples\kasutajaKaust";
            Console.WriteLine("Mis auto valiku soov teil on? 'toyota' 'bmw' 'tesla'");
            string userFile = Console.ReadLine();
            string fileDirectory = $@"{rootdirectory}\{userFile}.txt";
            bool excists = File.Exists(fileDirectory);

            if (excists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirectory);
                
                 
                        foreach (string line in dataFromFile)
                        {
                            Console.WriteLine(line);
                        }
                    
                    
                

            }
            else
                    {
                        Console.WriteLine($"{userFile}.txt file does not exist");
                    }
        }
    }
}
