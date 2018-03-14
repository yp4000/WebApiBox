using FluentAssertions;
using WebApiEntities;

namespace WebApiBoxTest
{
    internal static class AssertsForTest
    {

        internal static void AssertResponseContactAddOk(ContactDTO response)
        {
            response.ConctactId.Should().NotBe(null);
            response.Active.Should().Be(true);
            response.Nickname.Should().NotBeEmpty();
        }

    }
}
