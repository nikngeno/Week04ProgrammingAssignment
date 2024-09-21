namespace Week04ProgrammingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(quadraticFormula(1.0,2.83,1.2));
            Console.WriteLine(volumeFormula(1.0));
            f_theta();
        }
        static double quadraticFormula(double a, double b,double c)
        {
            double x1 = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2 * a);
            return x1 ;
        }
        static double volumeFormula (double r)
        {
            double volume = (4.0/3.0) * Math.PI * Math.Pow(r, 3);
            return volume ;
        }
        static void f_theta()
        {
            double theta = 0.523599;

            double sinTheta = Math.Sin(theta);
            double cosTheta = Math.Cos(theta);

            double f = (sinTheta * sinTheta) + (cosTheta * cosTheta);
            Console.WriteLine(f);
        }
    }
}
