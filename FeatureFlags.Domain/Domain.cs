using System.Collections;

namespace FeatureFlags.Domain
{
    public class Domain : Entity
    {
        public string Name { get; set; }

        public IList Environments { get; set; }
    }
}