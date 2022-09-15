using System;
using System.Collections.Generic;
using System.Linq;

namespace StarSavingTool.Console
{
    internal static class Program
    {
        public static void Main()
        {
            Task.Run(() => new Startup().RunAsync()).GetAwaiter().GetResult();
        }
    }
}
