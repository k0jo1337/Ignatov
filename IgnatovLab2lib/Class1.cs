namespace IgnatovLab1lib
{
    public class Class1
    {
        public double Zfunc1(double x, double y, double a)
        {
            return 12 * a - (3 * x + 2 * a + a) / (3 * a + 2 * x - y) + 12 * x + (((a - 1) / (y + 3)) / ((5 + a) / x));
        }
    }
    public class Class2
    {
        public double Zfunc2(double x2, double y2, double a2)
        {
            return Math.Round((2 * a2 / y2) + (4 * x2) + ((2 - 3 * a2) / (x2 - 7 * y2)) + (((a2 - 3) / (x2 + 3)) / (3 * a2 / (x2 - 1))));
        }
    }

}
