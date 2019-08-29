using Newtonsoft.Json;

namespace IG.SecondExercise.Dto
{
    public class Store
    {
        [JsonProperty("provider")]
        public Resources[] Provider { get; set; }

        [JsonProperty("demand")]
        public Requirements[] Demand { get; set; }
    }
}