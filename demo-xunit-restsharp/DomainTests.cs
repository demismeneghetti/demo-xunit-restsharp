using Xunit;

namespace PhoneBookTest
{
    public class DomainTests
    {
        [Fact]
        public void GetDomainTest()
        {
            var test = new DomainRequest();
            test.GetDomain();
        }
    }
}