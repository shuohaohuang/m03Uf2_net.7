/*Author shuohao Huang
 * Date 13/12/23
 * 
 */
using System;


namespace FigureArea
{

    public class FigureArea
    {

        public static void Main()
        {

            const string Msg = "Which regualr figure's area do you want calculate";

            const string Choose =
                "Insert:" +
            "\n0 for a cercle" +
            "\n4 for a sqaure" +

            "\nany else for other figures";

            const string Cercle = "Insert circle's radius";

            const string SquareBase = "Insert square's base ";

            const string SquareHeight = "Inset square's height";

            const string OtherFiguresSide = "Insert figure's sides";

            const string OtherFiguresSideWidth = "Insert figure's width";

            const string Result = "The figure's area is {0}";


            int side = 0;

            double width = 0, height = 0, radius = 0;



            Console.WriteLine(Msg);

            Console.WriteLine(Choose);


            string userInput = Console.ReadLine()??"0";

            switch (userInput)

            {

                case "0":

                    Console.WriteLine(Cercle);

                    radius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Result, CalculateFigureArea(radius));

                    break;

                case "4":

                    Console.WriteLine(SquareBase);

                    width = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(SquareHeight);

                    height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Result, CalculateFigureArea(width, height));

                    break;

                default:

                    Console.WriteLine(OtherFiguresSide);

                    side = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(OtherFiguresSideWidth);

                    width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Result, CalculateFigureArea(side, width));

                    break;

            }

        }


        public static double CalculateFigureArea(double width,
                                 double height)
        {

            //regular four faces figures 
            return Math.Abs(Math.Round(width * height, 3));


        }

        public static double CalculateFigureArea(double radius)
        {

            //circle
            return Math.Abs(Math.Round(radius * radius * Math.PI, 3));

        }

        public static double CalculateFigureArea(int side,double width )
        {

            //regular figures which has more than 4 side
            const int Four = 4;

            if (side == 3)
            {

                return Math.Abs(Math.Round(Math.Sqrt(3) / 4 * width * width, 3));

            }

            return Math.Abs(Math.Round(side * width * width /
                          (Four * Math.Tan(Math.PI / side)), 3));

        }

    }

}
