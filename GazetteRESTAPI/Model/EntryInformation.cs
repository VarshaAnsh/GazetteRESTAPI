using Newtonsoft.Json;
using System.Security.Principal;

namespace GazetteRESTAPI.Model
{
    //public class EntryInformation
    //{
    //    public string id { get; set; } = string.Empty;

    //}
}

public class EntryInformations
{
    public string id { get; set; }

    [JsonProperty("link")]
    public Link[] link { get; set; }
    public string title { get; set; }
    public DateTime updated { get; set; }
    [JsonProperty("openSearch:Query")]
    public OpensearchQuery openSearchQuery { get; set; }
    [JsonProperty("f:page-number")]
    public string fpagenumber { get; set; }
    [JsonProperty("f:page-size")]
    public string fpagesize { get; set; }
    [JsonProperty("f:page-start")]
    public string fpagestart { get; set; }
    [JsonProperty("f:page-stop")]
    public string fpagestop { get; set; }
    [JsonProperty("f:total")]
    public string ftotal { get; set; }
    [JsonProperty("f:total-errors")]
    public string ftotalerrors { get; set; }
    [JsonProperty("f:facets")]
    public object ffacets { get; set; }
  
    public Entry[] entry { get; set; }
}

public class OpensearchQuery
{
    [JsonProperty("@role")]
    public string role { get; set; }
}

public class Link
{
    [JsonProperty("@href")]
    public string href { get; set; }
    [JsonProperty("@rel")]
    public string @rel { get; set; }
    [JsonProperty("@type")]
    public string @type { get; set; }
    [JsonProperty("@title")]
    public string @title { get; set; }
}

public class Entry
{
    public string id { get; set; }

    [JsonProperty("f:status")]
    public string fstatus { get; set; }
    [JsonProperty("f:notice-code")]
    public string fnoticecode { get; set; }
    public string title { get; set; }
    public Link[] link { get; set; }
    public Author author { get; set; }
    public DateTime updated { get; set; }
    public DateTime published { get; set; }
    public Category category { get; set; }
    [JsonProperty("geo:Point")]
    public GeoPoint geoPoint { get; set; }
    public string content { get; set; }
}

public class Author
{
    public string name { get; set; }
}

public class Category
{
    [JsonProperty("@term")]
    public string term { get; set; }
}

public class GeoPoint
{
    [JsonProperty("geo:lat")]
    public string geolat { get; set; }
    [JsonProperty("geo:long")]
    public string geolong { get; set; }
}

//public class Link1
//{
//    public string href { get; set; }
//    public string rel { get; set; }
//    public string title { get; set; }
//    public string type { get; set; }
//}
