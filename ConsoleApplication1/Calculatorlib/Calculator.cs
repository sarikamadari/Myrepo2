using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorlib
{
  ///calculator class
  public class Calculator
  {
    /// <summary>
    /// input parameters
    /// </summary>
    /// <param name="a">1st parameter</param>
    /// <param name="b">2nd parameter</param>
    /// <returns>input for sum method</returns>

    public int sum(int a, int b)
    {
      return a + b;
    }
    public int multiply(int a, int b)
    {
      return a * b;
    }
    public int subtract(int a, int b)
    {
      return a - b;
    }
    public int division(int a, int b)
    {
      return a / b;
    }
  }
}

