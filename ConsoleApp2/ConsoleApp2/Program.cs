/*Author shuohao Huang
 * Date 13/12/23
 * 
 */
using System;

namespace Ej23
{
    class Ej23
    {
        static void Main()
        {

        }

        public static double CalculateFigureArea(double basse, double heigth)
        {
            //regular four faces figures 
            return Math.Round(basse * heigth, 3);

        }
        public static double CalculateFigureArea(double radius)
        {
            //circle
            return Math.Round(radius * radius * Math.PI, 3);
        }
        public double CalculateFigureArea(double basse, int side)
        {
            //regular figures which has more than 4 side
            const int Four = 4;
            const int Pi = 180;
            return Math.Round((side * basse * basse) / (Four * Math.Tan(Pi / side)), 3);
        }
    }
}