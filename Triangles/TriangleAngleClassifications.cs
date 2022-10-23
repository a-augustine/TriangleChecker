namespace CaselleTriangles
{
    public static class TriangleAngleClassification
    {
        public static Classification Acute { get; } = new AngleClassification("Acute");
        public static Classification Obtuse { get; } = new AngleClassification("Obtuse");
        public static Classification Right { get; } = new AngleClassification("Right");
        public static Classification Error { get; } = new AngleClassification("Error");
    }
}