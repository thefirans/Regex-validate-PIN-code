using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sasakk
        }
    }
    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            string pattern = @"\A([0-9]{4}|[0-9]{6})\z";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(pin);
            return result;
        }
    }
}

