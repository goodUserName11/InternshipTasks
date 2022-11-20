namespace AreaCalculator
{
    public class Circle : Figure
    {
        private int radius;

        public int Radius 
        {
            get => radius;

            set
            {
                if (value >= 0)
                    radius = value;
                else
                    throw new ArgumentException("Cannot be negative", nameof(value));
            } 
        }

        public Circle() { }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
