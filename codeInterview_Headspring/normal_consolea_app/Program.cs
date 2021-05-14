using codeInterview_HeadSpring;
using System;
using System.Collections.Generic;



namespace normal_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictPref = new Dictionary<int, string>();
            dictPref.Add(4,"Frog");
            dictPref.Add(13, "Duck");
            dictPref.Add(9, "Chicken");
            var objsuperFizzBuzz = new SuperFizzBuzz(dictPref);
            List<int> lsNumber = new List<int> { 5,6 };
            objsuperFizzBuzz.startSuperFizzBuzz(lsNumber);
        }
    }
}
