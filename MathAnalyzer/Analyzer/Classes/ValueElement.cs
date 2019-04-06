namespace Analyzer.Classes
{
    /// <summary>
    /// Numeric element
    /// </summary>
    class ValueElement : ClassValue
    {
        public override string Name { get; protected set; }

        public override double Value { get; protected set; }

        public ValueElement(double a)
        {
            this.Value = a;
            this.Name = a.ToString();
        }
    }
}
