using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests
{
   [TestFixture]
   public class BasicTests
   {
      [Test]
      public void Test_Truth()
      {
         bool expected = true;
         Assert.AreEqual(expected, true);
      }
   }
}
