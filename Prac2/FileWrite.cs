using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class FileWriter : IFileWriter
    {
        public void WriteArray(string path, double[] array)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    foreach (var value in array)
                    {
                        sw.WriteLine(value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error writing to file at {path}", ex);
            }
        }
    }
}
