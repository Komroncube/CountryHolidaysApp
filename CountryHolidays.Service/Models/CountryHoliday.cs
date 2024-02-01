﻿namespace CountryHolidays.Service.Models;
public class CountryHoliday
{
    public DateTime Date { get; set; }
    public string LocalName { get; set; }
    public string Name { get; set; }
    public string CountryCode { get; set; }
    public bool Fixed { get; set; }
    public bool Global { get; set; }
    public string[]? Counties { get; set; }
    public string? LaunchYear { get; set; }
    public string[]? Types { get; set; }
}
