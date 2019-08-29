using IG.SecondExercise.Enum;
using Newtonsoft.Json;

namespace IG.SecondExercise.Dto
{
    public class ResourceItem
    {
        [JsonProperty("resourceType")]
        public ResourceTypes ResourceType { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        public ResourceItem(ResourceTypes resourceType, int amount)
        {
            ResourceType = resourceType;
            Amount = amount;
        }

        private ResourceItem()
        {

        }
    }
}