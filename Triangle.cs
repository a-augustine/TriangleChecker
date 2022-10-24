using CaselleClassifications;

namespace CaselleTriangles
{
    public class Triangle
    {
        const int ROUND = 3;
        const Char DEGREE_SYMBOL = (Char)176;
        private bool isValid;

        SideClassification sideClassification;
        AngleClassification angleClassification;

        public Triangle(double sideA, double sideB, double sideC)
        {
            isValid = IsTriangleValid(sideA, sideB, sideC);

            sideClassification = new SideClassification(sideA, sideB, sideC);
            angleClassification = new AngleClassification(sideA, sideB, sideC);
        }

        // Function: Check for validity of the side of the triangle
        private bool SideIsValid(double addSide1, double addSide2, double validationSide)
        {
            return ((addSide1 + addSide2) > validationSide);
        }

        // Function: Checks to see if the triangle is valid or not
        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            if (
                SideIsValid(sideB, sideC, sideA)
                && SideIsValid(sideA, sideC, sideB)
                && SideIsValid(sideA, sideB, sideC))
            {
                return true;
            }
            return false;
        }
        
        // Function: Print out the details of the triangle
        public void PrintTriangleInformation()
        {
            Console.WriteLine();
            Console.WriteLine("--- Triangle Information ---");

            Console.WriteLine($"a = {sideClassification.sideA}({Math.Round(angleClassification.angleA, ROUND)}{DEGREE_SYMBOL})");
            Console.WriteLine($"b = {sideClassification.sideB}({Math.Round(angleClassification.angleB, ROUND)}{DEGREE_SYMBOL})");
            Console.WriteLine($"c = {sideClassification.sideC}({Math.Round(angleClassification.angleC, ROUND)}{DEGREE_SYMBOL})");
            if (isValid)
            {
                Console.WriteLine($"The triangle is valid");
            }
            else
            {
                Console.WriteLine($"The triangle is NOT valid");
            }
            // Check if the classification types are correct
            if (!(sideClassification.GetClassificationType() == ClassificationType.Side))
                throw new Exception($"Expected a side classification");

            if (!(angleClassification.GetClassificationType() == ClassificationType.Angle))
                throw new Exception($"Incorrect classification type");

            Console.WriteLine($"Side Classification: {sideClassification.name}");
            Console.WriteLine($"Angle Classification: {angleClassification.name}");
        }
    }
}
