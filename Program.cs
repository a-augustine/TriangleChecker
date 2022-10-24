// Coded by Adam Augustine

using CaselleTriangles;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double triangleSideA = 0;
                double triangleSideB = 0;
                double triangleSideC = 0;

                InputCheckerSingleton InputChecker = InputCheckerSingleton.Instance();

                Console.WriteLine("Enter triangle values for sides a, b and c. Press (enter/return) to continue.");

                triangleSideA = InputChecker.CheckForValidInput("a");
                triangleSideB = InputChecker.CheckForValidInput("b");
                triangleSideC = InputChecker.CheckForValidInput("c");

                Triangle triangle = new Triangle(triangleSideA, triangleSideB, triangleSideC);

                triangle.PrintTriangleInformation();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                return;
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}