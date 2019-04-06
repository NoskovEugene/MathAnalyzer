using Analyzer.Classes;

namespace Analyzer.Operators
{
    class Division : ClassOperator
    {
        public override string Name { get; } = "/";

        public override int Priority => 3;

        public override double Invoke(double a, double b = 0)
        {
            return a / b;
        }
    }
}
