using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prac2
{
    internal interface IFileWriter
    {
        void WriteArray(string path, double[] array);
    }
}
