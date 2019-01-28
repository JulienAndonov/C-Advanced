using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Session_5_Streams_Lec
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            using (var reader = new StreamReader(@"..\..\..\..\Resources\02. Line Numbers\Input.txt"))
            {

                using (var writer = new StreamWriter(@"..\..\..\..\Resources\02. Line Numbers\Output.txt"))
                {

                    while (true)
                    {
                        var buffer = reader.ReadLine();
                        if (buffer == null)
                        {
                            break;
                        }
                            writer.WriteLine(index + ". " + buffer);
                        
                        index++;

                    }
                }
            }
        }
    }
}
