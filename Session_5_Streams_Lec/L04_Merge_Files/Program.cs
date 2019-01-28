using System;
using System.IO;
using System.Linq;

namespace L04_Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"..\..\..\..\Resources\04. Merge Files\Output.txt"))
            {
                using (var readerFileOne = new StreamReader(@"..\..\..\..\Resources\04. Merge Files\FileOne.txt"))
                {
                    using (var readerFileTwo = new StreamReader(@"..\..\..\..\Resources\04. Merge Files\FileTwo.txt"))
                    {
                        

                        while (true)
                        {
                            var bufferFileOne = readerFileOne.ReadLine();
                            var bufferFileTwo = readerFileTwo.ReadLine();

                            if (bufferFileOne == null && bufferFileTwo == null)
                            {
                                break;
                            }

                            if (bufferFileOne != null)
                            {
                                writer.WriteLine(bufferFileOne);
                            }

                            if (bufferFileTwo != null)
                            {
                                writer.WriteLine(bufferFileTwo);
                            }

                        }


                    }
                }
            }
        }
    }
}