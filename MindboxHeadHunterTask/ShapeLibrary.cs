namespace MindboxHeadHunterTask
{
    public interface IShape
    {     
        double CalculateArea();
    }
    public class Circle : IShape
    {
        public double Radius { get; }
        /// <summary>
        /// Создать окружность по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("radius needs to be positive");

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        /// <summary>
        /// Создать треугольник по трём сторонам
        /// </summary>
        /// <param name="sideA">First Side</param>
        /// <param name="sideB">Second Side</param>
        /// <param name="sideC">Third Side</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
                throw new ArgumentException("sideA needs to be positive");
            if (sideB < 0)
                throw new ArgumentException("sideB needs to be positive");
            if (sideC < 0)
                throw new ArgumentException("sideC needs to be positive");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (!IsValidTriangle)
                throw new ArgumentException("no one side can be more two other summ");


        }

        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRectangular()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }

        private bool IsValidTriangle => SideA + SideB >= SideC && SideA + SideC >= SideB && SideB + SideC >= SideA;
    }
}
