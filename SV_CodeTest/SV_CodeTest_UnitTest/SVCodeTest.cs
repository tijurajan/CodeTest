using Microsoft.VisualStudio.TestTools.UnitTesting;
using SV_CodeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_CodeTest_UnitTest
{
   [TestClass]
    class SVCodeTest
    {
        [TestMethod]
        public void N_Equals_Zero_Throws_Error_Message()
        {
           var result=  Program.Game(0, 1);
            Assert.Equals(result.ErrorMsg, "Invalid number of participants or game factor");
        }

    }
}
