using Newtonsoft.Json;

namespace FeatureFlags.Domain
{
    public class Entity
    {
        [JsonIgnore]
        public long Id { get; set; }
    }
}