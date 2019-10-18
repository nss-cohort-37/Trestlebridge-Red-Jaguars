using System;
using System.Linq;

namespace Trestlebridge
{
    public static class Utils
    {
        /* 
        ** Git Bash, specifically, doesn't like dotnet telling it to clear the console.
        ** If `Console.Clear()` throws an exception, we're making the assumption that it's Git Bash running on a windows machine.
        ** We try explicitly running the clear.exe command. If for some reason that doesn't work,
        ** the last resort is to print 100 empty lines to the console....
        */
        public static void Clear()
        {
            try
            {
                Console.Clear();
            }
            catch (Exception)
            {
                try
                {
                    var process = System.Diagnostics.Process.Start(@"C:\Program Files\Git\usr\bin\clear.exe");
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
