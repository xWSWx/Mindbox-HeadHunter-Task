// See https://aka.ms/new-console-template for more information
using MindboxHeadHunterTask;
namespace LibraryConsumer
{
    public class Programm
    {
        public static double CalculateArea(IShape shape) => shape.CalculateArea();
        public static void Main(string[] args)
        {
            Circle cicle1 = new (5);
            Circle cicle2 = new(6.5);            
            Triangle triangle1 = new (1,2,3);
            Triangle triangle2 = new (3, 4, 5);
            
            Console.WriteLine(
                $"cicle1 area={CalculateArea(cicle1)} \n" + 
                $"cicle2 area={CalculateArea(cicle2)} \n" +
                $"triangle1 area={CalculateArea(triangle1)} \n" +
                $"triangle2 area={CalculateArea(triangle2)} \n" +
                $"triangle2 isRectangular={triangle2.IsRectangular().ToString()} \n"
                );
        }

    }

}