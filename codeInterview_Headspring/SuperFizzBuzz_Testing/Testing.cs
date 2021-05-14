using codeInterview_HeadSpring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static codeInterview_HeadSpring.SuperFizzBuzz;
using System.Collections.Generic;

namespace SuperFizzBuzz_Testing
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Test_A()
        {
            /* Test_A tests the advanced problem from -12 to 145 for No message (Numbers that are not dividable by any divisor given)
             * 
             */
            

            Dictionary<int, string> dictPref = new Dictionary<int, string>();
            dictPref.Add(3, "Fizz");
            dictPref.Add(7, "Buzz");
            dictPref.Add(38, "Bazz");
            var objsuperFizzBuzz = new SuperFizzBuzz(dictPref);
            List<int> lsNumber = new List<int> { -12, 145 };
            var oSuperBuzz = new SuperFizzBuzz(dictPref);
            objsuperFizzBuzz.startSuperFizzBuzz(lsNumber);

            //dictOutPut is the structure which I can test on


            Assert.AreEqual("", objsuperFizzBuzz.dictOutput[-11].ToString());
            Assert.AreEqual("", objsuperFizzBuzz.dictOutput[-10].ToString());
            Assert.AreEqual("", objsuperFizzBuzz.dictOutput[-8].ToString());

        }

      


        
    }
}
