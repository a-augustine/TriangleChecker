namespace CaselleClassifications
{
    public class AngleClassification : Classification
    {
        public double angleA { get; set; }
        public double angleB { get; set; }
        public double angleC { get; set; }
        public AngleClassification(double sideA, double sideB, double sideC)
        {
            // Calculate all three angles
            angleA = CalculateAngle(sideB, sideC, sideA);
            angleB = CalculateAngle(sideA, sideC, sideB);
            angleC = CalculateAngle(sideA, sideB, sideC);

            classification = CheckAngleClassification();

            this.name = GetName();
        }

        /// Function: Check the angle classification given all three triangle angles.
        private ClassificationAngleType CheckAngleClassification()
        {
            const int RIGHT_ANGLE = 90;
            // Check for a right angle
            if (angleA == RIGHT_ANGLE || angleB == RIGHT_ANGLE || angleC == RIGHT_ANGLE)
                return ClassificationAngleType.Right;

            // Check for an acute angle
            if (angleA < RIGHT_ANGLE && angleB < RIGHT_ANGLE && angleC < RIGHT_ANGLE)
                return ClassificationAngleType.Acute;

            // Check for an obtuse angle
            if (angleA > RIGHT_ANGLE || angleB > RIGHT_ANGLE || angleC > RIGHT_ANGLE)
                return ClassificationAngleType.Obtuse;

            return ClassificationAngleType.Error;
        }

        /// Function: Calculate the angle of a triangle given three side lengths.
        private static double CalculateAngle(double side1, double side2, double checkSide)
        {
            double result = Math.Acos((Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(checkSide, 2)) / (2 * side1 * side2));
            result *= 180 / Math.PI;
            return result;
        }

        public override ClassificationType GetClassificationType()
        {
            return ClassificationType.Angle;
        }
    }
}