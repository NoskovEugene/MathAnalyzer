using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analyzer;
using PolishNotation;
using Calculator;
using Analyzer.Functions;
using Analyzer.Classes;

namespace MathAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            _Analyzer _Analyzer = new _Analyzer();
            RevercePolishNotation notation = new RevercePolishNotation();
            List<IElement> elements = new List<IElement>();
            elements = _Analyzer.Analyze(Console.ReadLine());
            Show(elements,0);
            elements = notation.GetNotation(elements);
            Show(elements, 0);
            Console.WriteLine(new Calculator.Calculator().Calc(elements, 1));
            Console.ReadKey();
        }

        public static void Show(List<IElement> elements, int index)
        {
            string Pre = string.Empty;
            for (int i = 0; i < index; i++)
            {
                Pre += "-";
            }
            Pre += ">";
            foreach (IElement element in elements)
            {
                if (element.Type == ElementType.Function)
                {
                    Console.WriteLine($"{Pre} {element.Name} : {element.Type}");
                    Show(element.Context, index + 1);
                }
                else
                {
                    Console.WriteLine($"{Pre} {element.Name} : {element.Type}");
                }
            }
        }
    }
}
