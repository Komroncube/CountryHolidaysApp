using System.Collections;
using Newtonsoft.Json;
using CountryHolidays.Service.Models;

namespace CountryHolidays.Service;

public class CountryHolidayService : ICountryHolidayService
{
    private readonly HttpClient _client = new()
    {
        BaseAddress = new Uri("https://date.nager.at/api/v3/")
    };


    public async ValueTask<IEnumerable<CountryHoliday>> GetHolidaysAsync(int year, string countryCode="US")
    {
        var response = await _client.GetAsync($"PublicHolidays/{year}/{countryCode}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var holidays = JsonConvert.DeserializeObject<IEnumerable<CountryHoliday>>(content);

        return holidays;
    }

    public async ValueTask<IEnumerable<Country>> GetAvailableCountriesAsync()
    {
        var response = await _client.GetAsync("AvailableCountries");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var countries = JsonConvert.DeserializeObject<IEnumerable<Country>>(content);

        return countries;
    }
}
