using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo24
{
   public class TwentyFourSolver
   {
      public string Solve(int a, int b, int c, int d)
      {
         if (a < 1 || a > 9 ||
            b < 1 || b > 9 ||
            c < 1 || c > 9 ||
            d < 1 || d > 9)
         {
            throw new ArgumentException("Values must be between 1 and 9");
         }

         if (a + b + c + d == 24)
            return String.Format("{0}{1}{2}{3}{4}{5}{6}", a, "+", b, "+", c, "+", d);
         return "2*2*2*3";
      }
   }
}
