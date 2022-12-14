namespace CaselleTriangles
{

    public class InputCheckerSingleton
    {
        private static InputCheckerSingleton? instance;

        protected InputCheckerSingleton() { }
        public static InputCheckerSingleton Instance()
        {
            if (instance == null)
            {
                instance = new InputCheckerSingleton();
            }
            return instance;
        }

        public double CheckForValidInput(string value)
        {
            double result = 0;
            do
            {
                Console.Write($"{value} = ");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nERROR: user input must be a number value.");
                }
            } while (true);

            return result;
        }
    }
}