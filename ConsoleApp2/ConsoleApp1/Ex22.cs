/*Author Shuohao Huang
 * Date 18/12/23
 * Implementa un programa que simuli el moviment d'un 
 * objecte en un entorn 2D, representant així un escenari 
 * de videojoc. L'objecte té una posició inicial en l'origen (0, 0) 
 * i es mou en funció d'una velocitat i direcció controlades 
 * per funcions trigonomètriques. La velocitat inicial de 
 * l'objecte és d'1.0 unitats per segon, i la direcció inicial 
 * és de 45 graus respecte a l'eix positiu x. Durant la simulació, 
 * la direcció de l'objecte canviarà en intervals de 10 graus per a 
 * simular esdeveniments en el joc. Mostra la posició actual de 
 * l'objecte en cada iteració de la simulació. La simulació ha de 
 * tenir una durada total de 5 segons. Implementa el seu test unitari.
 */

namespace MovementSimulation
{
    public static class MovementSimulation
    {
        static void Main()
        {
           const double InitialPosionX = 0f, InitialPositionY = 0f;

           double positionX = InitialPosionX, positionY = InitialPositionY;
           double[] position = { positionX, positionY };
            for (int i = 0; i < 5; i++)
            {
                position = NewPosition(position[0], position[1], 45+10*i, 1);
                ShowPosition(position);
            }
        }
        static double[] NewPosition( double positionX, double PositionY, double direccion, double speed)
        {
            double[] position=new double[2];
            double oneRadian = 180;
            position[0]=Math.Round(positionX+Math.Cos(direccion/oneRadian)*speed,2);
            position[1]=Math.Round(PositionY+Math.Sin(direccion/oneRadian)*speed,2);
            return position;
        }
        static void ShowPosition( double[] position)
        {
            const string PositionX = "Position in X axes is {0}", PositionY = "Position in Y axes is {0}", Position = "({0} , {1} )";
            Console.WriteLine(PositionX, position[0]);
            Console.WriteLine(PositionY, position[1]);
            Console.WriteLine(Position, position[0], position[1]);
        }
    }
}