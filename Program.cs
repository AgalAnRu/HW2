using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInput getInput = new GetInput();
            double number = getInput.Double("INPUT: ");
            Console.WriteLine(number);
        }
    }
    internal class GetInput
    {
        internal double Double(string _askDouble)
        {

            string str = "";
            char c;
            int positionLastChar = -1; //MayBe ToDel
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            char separateChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (Console.CursorLeft > 0) _askDouble = "\n" + _askDouble;
            Console.Write(_askDouble);
            while (true)
            {
                cki = Console.ReadKey(true);
                c = cki.KeyChar;
                if (c == '.' || c == ',') c = separateChar;
                str += c.ToString();
                if (double.TryParse(str, out double result))
                    Console.Write(c);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return result;
                }
                   
                if (cki.Key == ConsoleKey.Backspace && str.Length > 0)
                {
                    str = str.Remove(str.Length - 1);
                    Console.Write("\b\b");
                }
            }
        }
    }
}
