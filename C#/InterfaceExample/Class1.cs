// See https://aka.ms/new-console-template for more information
using InterfaceExample;

public class Class1 : IMyInterface
{
    public int result = 2;
    
    public void Train(int[] data)
    { 
        int sum = 0;

        foreach (int value in data) 
        { 
            sum += value;

        }

        result = (sum>=100) ? 1 : 0;
        Console.WriteLine($" Result of the first class is:   {result}");

        //if (sum>=100)
        //{
        //    result = 1;
        //}

        //else
        //{
        //    result += 0;
        //}
    
    }

    public void Save(string filePath)
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
            string[] parts = content.Split(',');

            if (parts.Length == 3)
            {
                Result resultClass = new Result
                {
                    Average = double.Parse(parts[0]),
                    Median = int.Parse(parts[1]),
                    Variance = double.Parse(parts[2])
                };
                Console.WriteLine($"Result loaded from {filePath}");
            }
            else
            {
                Console.WriteLine($"Error: Invalid file content in {filePath}");
            }
        }
        else 
        {
            Console.WriteLine("File does not Exist...!");
        }
    
    }


}
