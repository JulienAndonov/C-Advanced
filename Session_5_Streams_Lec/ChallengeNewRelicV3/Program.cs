using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace NewRelicChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProcessEngine pe = new ProcessEngine();
            pe.Run(args);

        }
    }
}