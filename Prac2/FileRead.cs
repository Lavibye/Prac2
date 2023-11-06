using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class FileReader : IFileReader
    {
        public double[] ReadArray(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path).Select(double.Parse).ToArray();
            }
            catch (Exception ex)
            {
                throw new IOException($"Error reading file at {path}", ex);
            }
        }
    }
}
