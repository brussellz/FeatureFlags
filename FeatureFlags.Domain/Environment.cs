using System.Collections;

namespace FeatureFlags.Domain
{
    public class Environment : Entity
    {
        public string Name { get; set; }

        public IList FeatureFlags { get; set; }
    }
}