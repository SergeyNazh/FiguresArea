using System.Security.Cryptography.X509Certificates;

namespace FiguresArea
{
    public class FiguresOperations
    {
        // хотел создать общий интерфейс илм абстрактный класс, содержащий метод Square и градусную меру,
        // но разные сигнатуры и статичность классов этого не позволяют
        public static class Triangle
        {
            public static bool IsRectangular(double a, double b, double c)
            {
                return isValid(a, b, c) || isValid(b, a, c) || isValid(c, a, b);
                bool isValid(double a1, double b1, double c1) => Math.Pow(a1, 2) == Math.Pow(b1, 2) + Math.Pow(c1, 2);
            }
            public static double Square(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            // const неявно статичен
            public const double DegreeMeasure = 180;
        }
        public static class Circle
        {
            public static double Square(double r) => Math.PI * Math.Pow(r, 2);
            public const double DegreeMeasure = 360; 
        }
        public static class Rhomb
        {
            public static double Square(double d1, double d2) => 0.5 * d1 * d2;
            public const double DegreeMeasure = 360;
        }
    }
}
