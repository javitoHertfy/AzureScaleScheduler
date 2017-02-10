#load "..\..\Entities\NewRelicEntities.csx"

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

public class NewRelicService
{
    public IEnumerable<NewRelicInstance> GetInstances()
    {
        var client = new RestClient("https://api.newrelic.com/v2/applications/5933547/instances.json");
        var request = new RestRequest(Method.GET);
        request.AddHeader("X-Api-Key", "d04a238f058c142b3d849d3f4c3001da");
        var response = client.Execute(request);

        var result = JsonConvert.DeserializeObject<NewRelicResponse>(response.Content);
        return result.ApplicationInstances;
    }
}