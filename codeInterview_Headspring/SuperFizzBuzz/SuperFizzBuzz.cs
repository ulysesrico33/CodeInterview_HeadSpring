using System;
using System.Collections.Generic;

namespace codeInterview_HeadSpring
{
    //Start of class SuperFizzBuzz
    public class SuperFizzBuzz
    {


        private Dictionary<int, string> dictPref = new Dictionary<int, string>();
        public Dictionary<int, string> dictOutput = new Dictionary<int, string>();
        private List<string> lsFinalOutput = new List<string>();


        /// <summary>
        /// SuperFizzBuzz
        /// Initialize the class by passing the divisors and tokens
        /// </summary>
        /// <param name="dictPreferences"></param>
        public SuperFizzBuzz(Dictionary<int, string> dictPreferences)
        {
            //Adding the customizable labels for each possible dividend
            foreach (var item in dictPreferences)
                dictPref.Add(item.Key, item.Value);


        }
        



        /// <summary>
        /// startSuperFizzBuzz
        /// -Starts the whole process
        /// </summary>
        /// <param name="lsNumber"></param>
        public void startSuperFizzBuzz(List<int> lsNumber)
    {

        if (lsNumber.Count == 2)
        {
            //Case: Sequential

            //Sort the list to be able to walk throug the sequence of numbers
            lsNumber.Sort();

            for (int x = lsNumber[0]; x <= lsNumber[lsNumber.Count - 1]; x++)
                processDividend(x);
           
        }
        else
        {
            //Case: No sequential, no need to sort lsNumber
            foreach (var number in lsNumber)
               processDividend(number);
     
        }

        //Printing results

        foreach (var item in dictOutput)
        {
            //Case: The number wasn't dividend of any divisor, then it doesn't have a "token"
            if (item.Value == "")
                lsFinalOutput.Add(item.Key.ToString());
            else
                lsFinalOutput.Add(item.Value);


        }

        //Print the final result
        foreach (var item in lsFinalOutput)
            Console.WriteLine(item);



    }
        //End of startSuperFizzBuzz

        /// <summary>
        /// isDividedByNumber
        /// -Checks if the number is dividend of some divisor and add the token
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        private void isDividedByNumber(int dividend, int divisor)
    {
        //Add all the testing numbers
        if (!dictOutput.ContainsKey(dividend))
            dictOutput.Add(dividend, "");

        if ((dividend % divisor) == 0)
        {

            string currentOutputValue = dictOutput[dividend];
            currentOutputValue += dictPref[divisor];
            dictOutput[dividend] = currentOutputValue;


        }


    }


        /// <summary>
        /// processDividend
        /// -Process each dividend
        /// </summary>
        /// <param name="dividend"></param>
        private void processDividend(int dividend)
        {
        foreach (var item in dictPref)
            isDividedByNumber(dividend, item.Key);
        }

}
//End of class




}

