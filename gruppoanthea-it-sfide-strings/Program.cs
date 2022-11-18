using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;

namespace gruppoanthea_it_sfide_strings
{
    class Program
    {
        private static List<string> delimiters;

        static void Main(string[] args)
        {
            try
            {
                int result = Add(ConfigurationManager.AppSettings["strings"]);
                Console.WriteLine("Result: {0}", result);
            }
            catch(Exception e) { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }

        static int Add(string numbers)
        {
            int result = 0;

            if(!string.IsNullOrEmpty(numbers))
            {
                numbers = checkCustomDelimiters(numbers);

                List<int> _numbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .Where(x => x < 1000)
                    .ToList();

                List<int> _negative_numbers = _numbers
                    .Where(x => x < 0)
                    .ToList();

                if(_negative_numbers.Count() > 0)
                    throw new Exception("Negatives not allowed: " + string.Join(",", _negative_numbers.Select(n => n.ToString()).ToList()));

                result = _numbers.Sum();
            }

            return result;
        }

        private static string checkCustomDelimiters(string numbers)
        {
            string customDelimiters = Regex.Matches(numbers, @"//(.*?)//", RegexOptions.Singleline)
                .Cast<Match>()
                .Select(x => x.Groups[1].Value)
                .FirstOrDefault();

            if (string.IsNullOrEmpty(customDelimiters))
            {
                delimiters = new List<string>() { "," };
                return numbers;
            }

            getCustomDelimiters(customDelimiters);
            return numbers.Replace(string.Concat("//", customDelimiters, "//"), string.Empty);
        }

        private static void getCustomDelimiters(string customDelimiters)
        {
            Regex regex = new Regex(@"\[(.*?)\]");
            delimiters = regex.Matches(customDelimiters)
                .Cast<Match>()
                .Select(x => x.Groups[1].Value)
                .ToList();
        }
    }
}
