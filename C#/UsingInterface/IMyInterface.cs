using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterface
{
    internal interface IMyInterface
    {
        public void Train(int[] data);

        public void Save(string filePath);

        public void Load(string filePath);

    }
}
