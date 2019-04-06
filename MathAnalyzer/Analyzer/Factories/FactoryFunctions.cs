using System;
using System.Collections.Generic;
using Analyzer;
using Analyzer.Functions;
using Analyzer.Classes;


namespace Analyzer.Factories
{
    /// <summary>
    /// Factory function. Find function at name
    /// </summary>
    class FactoryFunctions
    {
        public IElement Function { get; private set; }

        readonly List<ClassFunction> Operators = new List<ClassFunction>()
        {
            new Sin(),
            new ArcSin(),
            new Cos(),
            new ArcCos(),
            new Tan(),
            new ArcTan(),
            new Ctg(),
            new ArcCtg(),
            new Sqrt(),
            new Sec(),
            new CoSec()
        };

        public bool Contains(string Input)
        {
            foreach (ClassFunction item in Operators)
            {
                if (Input.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                {
                    Function = item;
                    return true;
                }
            }
            return false;
        }

    }
}
