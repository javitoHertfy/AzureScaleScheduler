using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    // string path = "configuration.js";
    // log.Info($"aa FXSTimer trigger function executed at: {DateTime.Now}");

    // // Open the stream and read it back.
    // using (FileStream fs = File.Open(path, FileMode.Open))
    // {
    //     byte[] b = new byte[1024];
    //     UTF8Encoding temp = new UTF8Encoding(true);

    //     while (fs.Read(b, 0, b.Length) > 0)
    //     {
    //         log.Info(temp.GetString(b));
    //     }
    // }

    var instances = NewRelicService.GetInstances();
}

public class NewRelicService {
    public static IEnumerable<NewRelicInstance> GetInstances() {
        var client = new RestClient("https://api.newrelic.com/v2/applications/5933547/instances.json");
        var request = new RestRequest(Method.GET);
        request.AddHeader("X-Api-Key", "d04a238f058c142b3d849d3f4c3001da");
        var response = client.Execute(request);

        var result = JsonConvert.DeserializeObject<NewRelicResponse>(response.Content);
        return result.ApplicationInstances;
    }
}

public class NewRelicResponse {
    [JsonProperty("application_instances")]
    public IEnumerable<NewRelicInstance> ApplicationInstances;
}

public class NewRelicInstance {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("host")]
    public string Host { get; set; }

    [JsonProperty("application_summary")]
    public NewRelicApplicationSummary ApplicationSummary { get; set; }
}

public class NewRelicApplicationSummary {
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