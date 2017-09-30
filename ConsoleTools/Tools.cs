using System;
using System.Diagnostics;

namespace ConsoleTools
{
    public class Tools
    {
        public static void CleanLastLine()
        {
            Console.Write("\r" + new String(' ', Console.BufferWidth - 1));
        }

        [ConditionalAttribute("DEBUG")]
        public static void WaitForTheEnd()
        {
            Console.WriteLine("\rAppuyez sur une touche pour continuer...");
            Console.Read();
        }
    }
}
