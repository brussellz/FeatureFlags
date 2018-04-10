namespace FeatureFlags.Domain
{
    public class FeatureFlag : Entity
    {
        public string Name { get; set; }

        public bool IsAvailable { get; set; }
    }
}