﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Analyzer.Classes;

namespace Analyzer.Functions
{
    [Serializable]
    class Sec : ClassFunction
    {
        public override string Name => "SEC";

        public override double Value { get; set; }
        public override List<IElement> Context { get; set; }

        public override int Priority => 4;

        public override double Invoke(double X, double b = 0)
        {
            this.Value = 1 / Math.Cos(base.Analyse(X));
            return this.Value;
        }
    }
}
