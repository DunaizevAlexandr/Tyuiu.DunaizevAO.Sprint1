using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DunaizevAO.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            double rounder = Math.Round(3.14 * r* r*h, 4);
            return rounder;
        }
    }
}
