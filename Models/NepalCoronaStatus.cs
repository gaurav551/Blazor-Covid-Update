using System;

namespace BlazorCrud.Models
{

public class NepalCoronaStatus
{
    public int tested_positive { get; set; }
    public int tested_negative { get; set; }
    public int tested_total { get; set; }
    public int in_isolation { get; set; }
    public int quarantined { get; set; }
    public int tested_rdt { get; set; }
    public int pending_result { get; set; }
    public int recovered { get; set; }
    public int deaths { get; set; }
    public string source { get; set; }
    public DateTime updated_at { get; set; }
    public Latest_Sit_Report latest_sit_report { get; set; }
}

public class Latest_Sit_Report
{
    public string type { get; set; }
    public string _id { get; set; }
    public int no { get; set; }
    public string date { get; set; }
    public string url { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int __v { get; set; }
}

}