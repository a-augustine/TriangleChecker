namespace CaselleTriangles
{
    public class Triangle
    {
        private const int RIGHT_ANGLE = 90;

        private double sideA;
        private double sideB;
        private double sideC;
        private double angleA = 0;
        private double angleB = 0;
        private double angleC = 0;

        private bool isValid;

        private Classification sideClassification;
        private Classification angleClassification;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            isValid = IsTriangleValid();
            sideClassification = CheckSideClassification();
            angleClassification = CheckAngleClassification();
        }

        private bool SideIsValid(double addSide1, double addSide2, double validationSide)
        {
            return ((addSide1 + addSide2) > validationSide);
        }

        private bool IsTriangleValid()
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

        private Classification CheckSideClassification()
        {
            // Check if it is equilateral
            if ((sideA == sideB) && (sideA == sideC))
                return TriangleSideClassification.Equilateral;


            // Check if it is Scalene
            if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
                return TriangleSideClassification.Scalene;

            // Check if it is Isosceles
            return TriangleSideClassification.Isosceles;
        }

        private double CalculateAngle(double side1, double side2, double checkSide)
        {
            double result = Math.Acos((Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(checkSide, 2)) / (2 * side1 * side2));
            result *= 180 / Math.PI;
            return result;
        }

        private Classification CheckAngleClassification()
        {
            // Calculate all three angles
            angleA = CalculateAngle(sideB, sideC, sideA);
            angleB = CalculateAngle(sideA, sideC, sideB);
            angleC = CalculateAngle(sideA, sideB, sideC);

            // Check for a right angle
            if (angleA == RIGHT_ANGLE || angleB == RIGHT_ANGLE || angleC == RIGHT_ANGLE)
                return TriangleAngleClassification.Right;


            // Check for an acute angle
            if (angleA < RIGHT_ANGLE && angleB < RIGHT_ANGLE && angleC < RIGHT_ANGLE)
                return TriangleAngleClassification.Acute;


            if (angleA > RIGHT_ANGLE || angleB > RIGHT_ANGLE || angleC > RIGHT_ANGLE)
                return TriangleAngleClassification.Obtuse;

            return TriangleAngleClassification.Error;
        }

        public void PrintTriangleInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- Triangle Information ---");
            Console.WriteLine($"(a, b, c) == ({sideA}, {sideB}, {sideC}) == ({Math.Round(angleA, 3)}, {Math.Round(angleB, 3)}, {Math.Round(angleC, 3)})");
            if (isValid)
            {
                Console.WriteLine($"The triangle is valid");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The triangle is NOT valid");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"Side Classification: {sideClassification.name}");
            Console.WriteLine($"Angle Classification: {angleClassification.name}");
        }
    }
}
