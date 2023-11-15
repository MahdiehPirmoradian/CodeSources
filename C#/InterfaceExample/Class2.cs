using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Class2:IMyInterface
    {
        public void Train(int[] data)
        {
            int sum = 0;
            float Average = 0;
            float Average2 = 0;
            int median = 0;
            double variance = 0;

            foreach (int value in data) 
            {
                sum += value;
            }
            Average = sum/data.Length;
            Average2 = (float)data.Average();

            median = Median(data);
            variance = Variance(data, Average);

            GetResult(Average, median, variance);


        }

        public int Median(int[] data)
        {
            Array.Sort(data);

            // Find the middle index
            int middleIndex = data.Length / 2;

            // If the length is even, take the average of the two middle values
            if (data.Length % 2 == 0)
            {
                return (data[middleIndex - 1] + data[middleIndex]) / 2;
            }
            // If the length is odd, return the middle value
            else
            {
                return data[middleIndex];
            }


        }


        public double Variance(int[] data, float average)
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
            _variance = _varianceSum/data.Length;

            
            return _variance;
        }


        public Result GetResult(float _Average, int _Median, Double _Variance)
        {
            Result result = new Result();

            result.Average = _Average;
            result.Median = _Median;
            result.Variance = _Variance;

            return result;
        }

        public void Save(string filePath)
        { }

        public void Load(string filePath)
        { }
    }
}
