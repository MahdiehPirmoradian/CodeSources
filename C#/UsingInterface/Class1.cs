using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterface
{
    internal class Class1 : IMyInterface
    {
        public int sum = 0;
        int result = 2;
        string _filepath = @"C:\Exercise\test.txt";
        public void Train(int[] data)
        {
           

            foreach (int value in data) 
            {
                sum+= value;
            }

            
            
            result = (sum >= 100) ? 1 : 0;


            //if (sum >= 100)
            //{
            //    result = 1;
            //}
            //else
            //{
            //    result = 0;
            //}
            Console.WriteLine($"Result of first Class: {result}");

            Load(_filepath);
        }

        public void Save(String filePath) 
        {
            // Save the result to a text file
            string content = $"{result}";
            File.WriteAllText(filePath, content);
            Console.WriteLine($"Result saved to {filePath}");
        }

        public void Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine($"Result loaded from {filePath} is: {content}");

            }
            else
            {
                Console.WriteLine($"Error: Invalid file content in the path: {filePath}");
            }

        }

    }
}
