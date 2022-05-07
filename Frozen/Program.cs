using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;
            

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
                

            }

            //getter for Presents

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

            

        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] presentsFromFile = GetDataFromFile();

            foreach (string line in presentsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newPresents = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newPresents);
            }

            foreach (SecretSanta SecretSantaFromList in mySecretSanta)
            {
                Console.WriteLine($"{SecretSantaFromList.Name} wants {SecretSantaFromList.Gift} for cristmas.");
            }

        }

        public static void DisplatElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array : {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\....\OneDrive\Töölaud\TKTK\III aasta\Programmeerimise algkursus\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }

}
