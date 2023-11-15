// See https://aka.ms/new-console-template for more information
using UsingInterface;

public class Class2 : IMyInterface
{
    public void Train(int[] data)
    {
        int sum = 0;
       
        foreach(int value in data)
        {
            sum += value;
        }

        double _ave = Average(sum, data);

        double _ave1 = data.Average();

        double _median = Median(data);

        double _variance = Variance(data, _ave);

        GetResult(_ave, _median, _variance);
    }
    
    public double Average(int Sum, int[] data )
    {
        
        double _ave = Sum/data.Length;

        return _ave;
    }


    public double Median(int[] data)
    {
        double _median = 0;
        Array.Sort(data);
        int _middleIndex = data.Length / 2;

        if (data.Length % 2 == 0)
        {
            _median = (data[_middleIndex] + data[_middleIndex-1])/2;
        }
        else 
        {
            _median = data[_middleIndex];
        }

        return _median;
    }

    public double Variance (int[] data, double average)
    {
        double _varianceSum = 0;
        double _difference = 0;
        double _squareDifference = 0;
        double _variance = 0;

        foreach (int value in data)
        {
            _difference = value - average;
            _squareDifference = Math.Pow(_difference, 2);
            _varianceSum += _squareDifference;

        }
        _variance = _varianceSum / data.Length;


        return _variance;
    }

    public Result GetResult(double Average, double Median, double Variance)
    {
        Result result = new Result();
        result.Average = Average;
        result.Median = Median;
        result.Variance = Variance;
        return result;
    }

    public void Save(String filePath)
    {
        // Save the result to a text file

    }

    public void Load(string filePath)
    {
        



    }

}


