using System;
using System.Text;

namespace ConsoleTools
{
    public class Security
    {
        public static string GetPassword()
        {
            StringBuilder pwd = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter) break;
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
                        pwd.Remove(pwd.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    if (char.IsLetterOrDigit(i.KeyChar) || char.IsPunctuation(i.KeyChar) || char.IsSymbol(i.KeyChar) || char.IsWhiteSpace(i.KeyChar))
                    {
                        pwd.Append(i.KeyChar);
                        Console.Write("*");
                    }

                }
            }

            return pwd.ToString();
        }
    }
}
