using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace PhoneBookTest
{
    public class ContactsTest
    {
        [Theory]
        [InlineData("56d5efa8c82593800291c02b", "Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.NoContent)]
        [InlineData("", "Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.NotFound)]
        [InlineData("56d5efa8c82593800291c02b", "Camila Meneghetti", "", "", HttpStatusCode.NoContent)]
        [InlineData("5c82550d7bc4cd822cc86e20", "", "", "", HttpStatusCode.NoContent)]
        public void PutTest(string id, string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var test = new ContactsPage();
            test.PutContact(id, name, mobilephone, homephone, code);
        }

        [Theory]
        [InlineData("Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.Created)]
        [InlineData("", "", "", HttpStatusCode.BadRequest)]
        [InlineData("Camila Meneghetti", "", "", HttpStatusCode.BadRequest)]
        [InlineData("", "351912978005", "", HttpStatusCode.BadRequest)]
        [InlineData("", "", "351222333444", HttpStatusCode.BadRequest)]
        [InlineData("", "", "", HttpStatusCode.BadRequest)]
        public void PostTest(string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var test = new ContactsPage();
            test.PostContact(name, mobilephone, homephone, code);
        }
    }
}
