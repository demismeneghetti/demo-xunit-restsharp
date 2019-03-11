using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PhoneBookTest
{
    public class DomainTests
    {
        [Fact]
        public void GetDomainTest()
        {
            var test = new DomainPage();
            test.GetDomain();
        }
    }
}