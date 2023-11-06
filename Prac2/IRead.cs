using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal interface IFileReader
    {
        double[] ReadArray(string path);
    }
}
