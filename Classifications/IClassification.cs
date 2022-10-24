namespace CaselleClassifications
{
    public interface IClassification
    {
        string name { get; set; }
        Enum classification { get; set; }
        ClassificationType GetClassificationType();
        string GetName();
    }
}