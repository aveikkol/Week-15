using System;
using System.IO;
using System.Collections.Generic;


namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string gift;
            

            public Frozen(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for Frozen 

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
            List<Frozen> myFrozens = new List<Frozen>();
            string[] frozensFromFile = GetDataFromFile();

            foreach (string line in frozensFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new(tempArray[0], tempArray[1]);
                myFrozens.Add(newFrozen);

            }
            foreach (Frozen frozenFromList in myFrozens)
            {
                Console.WriteLine($"Name --> {frozenFromList.Name}. Gift --> {frozenFromList.Gift}");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array:{element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\angel\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;

        }
    }
}
