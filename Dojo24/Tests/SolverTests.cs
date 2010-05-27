using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dojo24;

namespace Tests
{
   [TestFixture]
   public class SolverTests
   {
      TwentyFourSolver solver;

      [SetUp]
      public void Setup()
      {
        solver = new TwentyFourSolver();
      }

      [Test]
      public void Solver_Returns_Answer_That_Evals_To_24_For_Simple_Problem()
      {
         //24 = 2 * 2 * 2 * 3
         string solution = solver.Solve(2, 2, 2, 3);

         Assert.AreEqual("2*2*2*3", solution);
      }

      [Test]
      [ExpectedException(typeof(ArgumentException))]
      public void Solver_Requires_Integers_From_One_To_Nine()
      {
         solver.Solve(0, 1, 1, 1);
      }
   }
}
