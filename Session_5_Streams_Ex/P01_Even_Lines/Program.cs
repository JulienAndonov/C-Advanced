using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Session_5_Streams_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            using (var writer = new StreamWriter(@"..\..\..\..\Resources\output.txt"))
            {
                using (var reader = new StreamReader(@"..\..\..\..\Resources\text.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        
                        if (counter % 2 == 0)
                        {
                            line = ReplaceString(line);
                            writer.WriteLine(line);

                        }
                        
                        counter++;
                        
                    }
                    

                }
            }
        }


        public static string ReplaceString(string entryString)
        {
            var words = entryString.Split(" ");
            StringBuilder resultString = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                resultString.Append(words[i]);
                if (i != 0)
                {
                    resultString.Append(' ');
                }
            }

            
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[i] == '-'
                    || resultString[i] == ','
                    || resultString[i] == '.'
                    || resultString[i] == '!'
                    || resultString[i] == '?'
                )
                {
                    resultString[i] = '@';
                }
            }
            

            return resultString.ToString();
        }
    }
}
