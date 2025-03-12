using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class OBJ
{
    [JsonProperty("Opportunity Name")]
    public string OpportunityName { get; set; }
    public string Amount { get; set; }

    [JsonProperty("Closer Date")]
    public string CloserDate { get; set; }

    [JsonProperty("Opportunity Stage")]
    public string OpportunityStage { get; set; }

    [JsonProperty("Opportunity Type")]
    public string OpportunityType { get; set; }

    [JsonProperty("Lead Source")]
    public string LeadSource { get; set; }
}

class Program
{
    static void Main()
    {
        string input = "\nOpportunity Name: \"DotNet Backender Developer\"\nAmount: 100\nCloser Date: 11/7/2018\nOpportunity Stage: Prospecting\nOpportunity Type: New\nLead Source: Partner Referral";
        Console.WriteLine(input);
        String json = ConvertToJsonObject(input).ToString();
        obj root = JsonConvert.DeserializeObject<OBJ>(json)??new OBJ();
        Console.WriteLine(json);
    }

    static JObject ConvertToJsonObject(string input)
    {

        JObject jsonObject = new JObject();
        var lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            if (parts.Length == 2)
            {
                var key = parts[0].Trim();
                var value = parts[1].Trim().Replace("\"","") ;
                //value=value.[1];
                jsonObject[key] = JToken.FromObject(value);
            }
        }

        return jsonObject;
    }
    
}
