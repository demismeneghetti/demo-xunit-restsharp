using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace PhoneBookTest
{
    public class ContactTest
    {
        [Theory]
        [InlineData("Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.Created)]
        [InlineData("", "", "", HttpStatusCode.BadRequest)]
        [InlineData("Camila Meneghetti", "", "", HttpStatusCode.BadRequest)]
        [InlineData("", "351912978005", "", HttpStatusCode.BadRequest)]
        [InlineData("", "", "351222333444", HttpStatusCode.BadRequest)]
        public void PostContactTest(string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var test = new ContactsPage();
            test.PostContact(name, mobilephone, homephone, code);
        }

        [Theory]
        [InlineData("name", "Demis Meneghetti", HttpStatusCode.OK)]
        [InlineData("name", "", HttpStatusCode.NoContent)]
        [InlineData("name", "!@#$%¨&*()", HttpStatusCode.NotFound)]
        [InlineData("mobilephone", "351912978005", HttpStatusCode.OK)]
        [InlineData("mobilephone", "", HttpStatusCode.NotFound)]
        [InlineData("mobilephone", "!@#$%¨&*()", HttpStatusCode.NotFound)]
        [InlineData("homephone", "351222333444", HttpStatusCode.OK)]
        [InlineData("homephone", "", HttpStatusCode.NotFound)]
        [InlineData("homephone", "!@#$%¨&*()", HttpStatusCode.NotFound)]
        public void GetContactTest(string parameter_type, string parameter_content,  HttpStatusCode code)
        {
            var test = new ContactsPage();
            test.GetContact(parameter_type, parameter_content, code);
        }

        [Theory]
        [InlineData("56d5efa8c82593800291c02b", "Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.NoContent)]
        [InlineData("", "Demis Meneghetti", "351912978005", "351222333444", HttpStatusCode.NotFound)]
        [InlineData("56d5efa8c82593800291c02b", "Camila Meneghetti", "", "", HttpStatusCode.NoContent)]
        [InlineData("5c82550d7bc4cd822cc86e20", "", "", "", HttpStatusCode.NoContent)]
        public void PutContactTest(string id, string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var test = new ContactsPage();
            test.PutContact(id, name, mobilephone, homephone, code);
        }
    }
}
