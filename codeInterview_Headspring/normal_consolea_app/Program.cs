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
            List<int> lsNumber = new List<int> { 50,51,52,30,36,468,469 };

            try
            {
                objsuperFizzBuzz.startSuperFizzBuzz(lsNumber);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: "+ex.ToString());
            }

            
            
        }
    }
}
