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
            int index = 0;
            using (var reader = new StreamReader(@"..\..\..\..\Resources\01. Odd Lines\Input.txt"))
            {

                using (var writer = new StreamWriter(@"..\..\..\..\Resources\01. Odd Lines\Output.txt"))
                {

                    while (true)
                    {
                        var buffer = reader.ReadLine();
                        if (buffer == null)
                        {
                            break;
                        }

                        if (index % 2 != 0)
                        {
                            writer.WriteLine(buffer);
                        }
                        index++;

                    }
                }
            }
        }
    }
}
