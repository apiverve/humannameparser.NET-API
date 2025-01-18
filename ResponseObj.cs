using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class parsed
{
    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("first")]
    public string first { get; set; }

    [JsonProperty("middle")]
    public string middle { get; set; }

    [JsonProperty("last")]
    public string last { get; set; }

    [JsonProperty("nick")]
    public string nick { get; set; }

    [JsonProperty("suffix")]
    public string suffix { get; set; }

}

public class data
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("parsed")]
    public parsed parsed { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
