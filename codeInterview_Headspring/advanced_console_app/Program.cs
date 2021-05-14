using codeInterview_HeadSpring;
using System;
using System.Collections.Generic;

namespace advanced_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictPref = new Dictionary<int, string>();
            dictPref.Add(3, "Fizz");
            dictPref.Add(7, "Buzz");
            dictPref.Add(38, "Bazz");
            var objsuperFizzBuzz = new SuperFizzBuzz(dictPref);
            List<int> lsNumber = new List<int> { -12,145 };

            try
            {
                objsuperFizzBuzz.startSuperFizzBuzz(lsNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
