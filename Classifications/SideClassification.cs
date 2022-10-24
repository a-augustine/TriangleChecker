namespace CaselleClassifications
{
    public class SideClassification : Classification
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public SideClassification(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            classification = CheckSideClassification();

            this.name = GetName();
        }

        /// Function: Check for the side classification using the triangles three sides.
        private ClassificationSideType CheckSideClassification()
        {
            // Check if it is equilateral
            if ((sideA == sideB) && (sideA == sideC))
                return ClassificationSideType.Equilateral;

            // Check if it is Scalene
            if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
                return ClassificationSideType.Scalene;

            // Check if it is Isosceles
            return ClassificationSideType.Isosceles;
        }

        public override ClassificationType GetClassificationType()
        {
            return ClassificationType.Side;
        }
    }
}