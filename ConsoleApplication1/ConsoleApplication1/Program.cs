using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      var calc = new Calculatorlib.Calculator();
      var result = calc.sum(2, 1);
      Console.WriteLine(result);
      result = calc.subtract(2, 1);
      Console.WriteLine(result);
      result = calc.subtract(2, 1);
      Console.WriteLine(result);
      Console.ReadLine();
    }
  }
}
