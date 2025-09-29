using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DunaizevAO.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            double z = (3 + Math.Exp(y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x)));
            double res = Math.Round(z, 3);
            return res;
        }
    }
}
