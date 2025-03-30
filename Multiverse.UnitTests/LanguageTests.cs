using Multiverse.Languages;
using Xunit;

namespace Multiverse.UnitTests
{
    public class LanguageTests
    {
        [Fact]
        public void GetAllLanguages_Should_ReturnAllLanguages()
        {
            List<Language>? languages = Language
                .GetAllLanguages()
                .ToList();

            Assert.NotEmpty(languages);

            Assert.Contains(Language.None, languages);
        }
    }
}
