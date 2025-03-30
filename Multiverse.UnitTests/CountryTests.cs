using Multiverse.Models;
using Xunit;

namespace Multiverse.UnitTests
{
    public class CountryTests
    {
        [Fact]
        public void GetAllLanguages_Should_ReturnAllLanguages()
        {
            List<Country>? countries = Country
                .GetAllCountries()
                .ToList();

            Assert.NotNull(countries);

            Assert.Contains(Country.None, countries);
        }
    }
}
