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
            /* Test_A tests the advanced problem from -12 to 145 (Sequence)
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


            List<int> lsTest1 = new List<int>() { -11, -10, -8 };

            foreach (var item in lsTest1) 
                Assert.AreEqual("", objsuperFizzBuzz._dictOutput[item].ToString());

            List<int> lsTest2 = new List<int>() { -12, -9, -6 };

            foreach (var item in lsTest2)
                Assert.AreEqual("Fizz", objsuperFizzBuzz._dictOutput[item].ToString());


        }


        [TestMethod]
        public void Test_B() 
        {

            //Test B: Testing a No sequential input
            Dictionary<int, string> dictPref = new Dictionary<int, string>();
            dictPref.Add(4, "Frog");
            dictPref.Add(13, "Duck");
            dictPref.Add(9, "Chicken");
            List<int> lsNumber = new List<int> { 50, 51, 52, 30, 36, 468, 469 };
            var oSuperBuzz = new SuperFizzBuzz(dictPref);
            oSuperBuzz.startSuperFizzBuzz(lsNumber);

            //dictOutPut is the structure which I can test on


            List<int> lsTest1 = new List<int>() { 50,51,30,469 };

            foreach (var item in lsTest1)
                Assert.AreEqual("", oSuperBuzz._dictOutput[item].ToString());

            List<int> lsTest2 = new List<int>() { 52};

            foreach (var item in lsTest2)
                Assert.AreEqual("FrogDuck", oSuperBuzz._dictOutput[item].ToString());

            List<int> lsTest3 = new List<int>() { 36 };

            foreach (var item in lsTest3)
                Assert.AreEqual("FrogChicken", oSuperBuzz._dictOutput[item].ToString());

            List<int> lsTest4 = new List<int>() { 468 };

            foreach (var item in lsTest4)
                Assert.AreEqual("FrogDuckChicken", oSuperBuzz._dictOutput[item].ToString());
        }

      


        
    }
}
