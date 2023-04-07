namespace Geometry
{
    public class Class1
    {
        public static double CircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть > 0");
            }

            return Math.PI * radius * radius;
        }

        public static double TriangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны должны быть > 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Сумма двух сторон меньше чем третья сторона");
            }

            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны должны быть > 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Сумма двух сторон меньше чем третья сторона");
            }

            
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;
            return Math.Abs(a2 + b2 - c2) < 1e-10 || Math.Abs(a2 + c2 - b2) < 1e-10 || Math.Abs(b2 + c2 - a2) < 1e-10;
        }
    }
}
