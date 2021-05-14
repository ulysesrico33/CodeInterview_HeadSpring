using System;
using System.Collections.Generic;

namespace codeInterview_HeadSpring
{
    public class SuperFizzBuzz
    {


        private Dictionary<int, string> dictPref = new Dictionary<int, string>();
        private Dictionary<int, string> dictOutput = new Dictionary<int, string>();
        public  SuperFizzBuzz(Dictionary<int,string> dictPreferences)
        {
            //Adding the customizable labels for each possible dividend
            foreach (var item in dictPreferences) 
                dictPref.Add(item.Key, item.Value);
               
        
        }

       
       
    

        public void startSuperFizzBuzz(List<int> lsNumber) 
        {
            bool res;
                
                if (lsNumber.Count == 2)
                {
                //Case: Sequential

                for (int x = lsNumber[0]; x <= lsNumber[lsNumber.Count - 1]; x++)
                {
                    //Take everynumber from sequence


                    foreach (var item in dictPref)
                    {

                        isDividedByNumber(x, item.Key);

                    }
                }

                   
                }
                else 
                {
                //Case: No sequential
                    foreach (var number in lsNumber) 
                    {
                        foreach (var item in dictPref)
                        {

                            isDividedByNumber(number, item.Key);

                        }

                }
                }
            
        }

        private void isDividedByNumber(int dividend,int divisor) 
        {

            if ((dividend % divisor) == 0)
            {
                if (dictOutput.ContainsKey(dividend)) 
                {
                    string currentOutputValue = dictOutput[dividend];
                    currentOutputValue += dictPref[divisor];
                    dictOutput[dividend] = currentOutputValue;
                }
            
            }


        }
    }
}
