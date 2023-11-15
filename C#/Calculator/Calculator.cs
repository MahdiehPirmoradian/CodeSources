// See https://aka.ms/new-console-template for more information
public class Calculator
{
    int sum = 0;
    
    public int Add(params int[] numbers)
    { 
        foreach(var number in numbers)
        {  
            sum += number; 
        }

        return sum;
    }
}