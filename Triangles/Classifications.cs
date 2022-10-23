namespace CaselleTriangles
{
    public abstract class Classification
    {
        public string name = "";
        public abstract ClassificationType GetClassificationType();
    }

    public class SideClassification : Classification
    {
        public SideClassification(string name)
        {
            this.name = name;
        }

        public override ClassificationType GetClassificationType()
        {
            return ClassificationType.Side;
        }
    }

    public class AngleClassification : Classification
    {
        public AngleClassification(string name)
        {
            this.name = name;
        }

        public override ClassificationType GetClassificationType()
        {
            return ClassificationType.Angle;
        }
    }

    public enum ClassificationType
    {
        Side,
        Angle
    }
}