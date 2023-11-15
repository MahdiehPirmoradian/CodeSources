using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal interface IMyInterface
    {
        void Train(int[] data);


        void Save(string filePath);

        void Load(string filePath);
    }
}
