using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    var client = new RestClient("https://staticconent.blob.core.windows.net/test/configuration.json");
    var request = new RestRequest(Method.GET);
    var response = client.Execute(request);

    var result = JsonConvert.DeserializeObject<ServiceConfigurationResponse>(response.Content);

    log.Info($"Name : {response.Content}");

    //foreach (var serviceConfiguration in result)
    //{
    //    log.Info($"Name : {serviceConfiguration.Name}");

    //}
}

public class ServiceConfigurationResponse
{
    [JsonProperty("services")]
    public IEnumerable<ServiceConfiguration> ServicesConfiguration { get; set; }
}

public class ServiceConfiguration
{
    [JsonProperty("default")]
    public string DefaultConfiguration { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("scaled_down")]
    public string ScaledDown { get; set; }

    [JsonProperty("scaled_down_times")]
    public string ScaledDownTimes { get; set; }

    [JsonProperty("scaled_up")]
    public string ScaledUp { get; set; }

    [JsonProperty("scaled_up_times")]
    public string ScaledUpTimes { get; set; }

    [JsonProperty("special_events")]
    public string SpecialEvents { get; set; }

    [JsonProperty("special_events_scale_up")]
    public string SpecialEventsScaleUp { get; set; }

    [JsonProperty("special_events_times")]
    public string SpecialEventsTimes { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

}


