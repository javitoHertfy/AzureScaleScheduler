using System;
using Newtonsoft.Json;

namespace FunctionTest2.Entities.NewRelicEntities
{
    public class NewRelicResponse
    {
        [JsonProperty("application_instances")]
        public IEnumerable<NewRelicInstance> ApplicationInstances;
    }

    public class NewRelicInstance
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("application_summary")]
        public NewRelicApplicationSummary ApplicationSummary { get; set; }
    }

    public class NewRelicApplicationSummary
    {
        [JsonProperty("response_time")]
        public int ResponseTime { get; set; }

        [JsonProperty("throughput")]
        public float Throughput { get; set; }

        [JsonProperty("error_rate")]
        public float ErrorRate { get; set; }

        [JsonProperty("apdex_score")]
        public float ApdexScore { get; set; }

        [JsonProperty("instance_count")]
        public float InstanceCount { get; set; }
    }
}
