namespace CaselleTriangles
{
    public static class TriangleSideClassification
    {
        public static Classification Scalene { get; } = new SideClassification("Scalene");
        public static Classification Isosceles { get; } = new SideClassification("Isosceles");
        public static Classification Equilateral { get; } = new SideClassification("Equilateral");
        public static Classification Error { get; } = new SideClassification("Error");

    }
}