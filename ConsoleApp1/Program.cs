using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { //a
        }
    }
    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            bool result = false;
            if (pin.Length == 4 || pin.Length == 6)
            {
                if (Regex.IsMatch(pin, @"[0-9]{4}{6}"))
                {
                    result = true;
                }
                else result = false;
            }
            else result = false;
            return result;
        }
    }
}
