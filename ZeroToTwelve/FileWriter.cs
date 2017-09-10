using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroToTwelve
{
    public static class FileWriter
    {
        public static void CSV (string filePath, IEnumerable<int[]> list, string header)
        {
            using (var file = new StreamWriter(filePath))
            {
                file.Write(header);

                foreach (var array in list)
                {
                    file.WriteLine();

                    foreach (var integer in array)
                    {
                        file.Write(integer.ToString() + ",");  
                     
                    }
                }
            }
        }
    }
}
