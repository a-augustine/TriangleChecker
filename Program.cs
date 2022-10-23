// Coded by Adam Augustine

namespace CaselleTriangles
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
                TriangleChecker TriangleCheck = new TriangleChecker();

                Console.WriteLine("Enter triangle values for sides a, b and c");

                triangleSideA = InputChecker.CheckForValidInput("a");
                triangleSideB = InputChecker.CheckForValidInput("b");
                triangleSideC = InputChecker.CheckForValidInput("c");

                Triangle triangle = new Triangle(triangleSideA, triangleSideB, triangleSideC);

                triangle.PrintTriangleInformation();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}