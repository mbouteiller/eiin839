using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Calcul.CalculatorSoap calculator = new Calcul.CalculatorSoapClient();

            Console.WriteLine(calculator.Add(8, 6));

            Console.ReadLine();
        }
    }
}
