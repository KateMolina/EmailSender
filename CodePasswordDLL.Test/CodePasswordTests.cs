using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodePasswordDLL.Test
{
    [TestClass]
    public class CodePasswordTests
    {
        [TestMethod]
        public void getCodPassword_abc_bcd()
        {
            string strIn = "abc";
            string strExpected = "bcd";

            string strActual = CodePassword.getCodedPass(strIn);

            Assert.AreEqual(strExpected, strActual);
        }
    }
}
