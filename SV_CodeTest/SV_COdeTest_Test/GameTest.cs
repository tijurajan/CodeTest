using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SV_CodeTest;

namespace SV_COdeTest_Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void N_Equals_Zero_Throws_Error_Message()
        {
           
            var result = Program.Game(0, 1);
            Assert.AreEqual(result.ErrorMsg, "Invalid number of participants or game factor");
        }
        [TestMethod]
        public void K_Equals_Zero_Throws_Error_Message()
        {

            var result = Program.Game(5, 0);
            Assert.AreEqual(result.ErrorMsg, "Invalid number of participants or game factor");
        }
        [TestMethod]
        public void Valid_Result_FoR_Winner()
        {

            var result = Program.Game(10, 3);
            Assert.IsTrue(result.Winner ==4);
        }
        [TestMethod]
        public void Check_If_Number_Of_Children_Out_Is_One_Less_Than_Count()
        {

            var result = Program.Game(100, 6);
            Assert.IsTrue(result.Out.Count == 99);
        }
    }
    
}
