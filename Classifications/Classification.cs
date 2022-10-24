namespace CaselleClassifications
{
    public abstract class Classification : IClassification
    {
        public string name { get; set; } = "";
        public Enum classification { get; set; } = ClassificationType.Error;

        public abstract ClassificationType GetClassificationType();

        /// Function: return the name of the enum from the classification
        public string GetName()
        {
            // Throw an exception if there was an error getting the classification name from the enum
            string? classificationName = Enum.GetName(classification.GetType(), classification);
            if (classificationName == null)
            {
                throw new Exception("An exception occurred getting the classification name. Classification type was null.");
            }

            return classificationName;
        }
    }
}