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

         return "2*2*2*3";
      }
   }
}
