using Analyzer.Classes;


namespace Analyzer.Operators
{
    class Substraction : ClassOperator
    {
        public override string Name { get; } = "-";

        public override int Priority => 2;

        public override double Invoke(double a, double b = 0)
        {
            return a - b;
        }
    }
}
