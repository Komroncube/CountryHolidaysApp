using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryHolidays.Service.Models;

namespace CountryHolidays.Service;
public interface ICountryHolidayService
{
    ValueTask<IEnumerable<CountryHoliday>> GetHolidaysAsync(int year, string countryCode = "US");
    ValueTask<IEnumerable<Country>> GetAvailableCountriesAsync();
}
