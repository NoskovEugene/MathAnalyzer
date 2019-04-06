using System.Collections.Generic;
using Analyzer;
using Analyzer.Operators;
using Analyzer.Classes;

namespace Analyzer.Factories
{
    /// <summary>
    /// Factory operator. Find operator at name
    /// </summary>
    class FactoryOperators
    {
        public IElement Operator { get; private set; }

        readonly List<ClassOperator> Operators = new List<ClassOperator>()
        {
            new Multiplication(),
            new Division(),
            new Addition(),
            new Substraction(),
            new Exponentiation(),
        };

        public bool Contains(char Input)
        {
            foreach(ClassOperator item in Operators)
            {
                if (char.Parse(item.Name) == Input)
                {
                    Operator = item;
                    return true;
                }
            }
            return false;
        }

    }
}
