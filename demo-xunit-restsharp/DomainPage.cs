using FluentAssertions;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace PhoneBookTest
{
    public class DomainPage
    {
        public const string URL = "http://localhost:5000";

        public void GetDomain()
        {
            RestClient client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, statusCode);

            var message = response.Content;
            Assert.Equal("! :) :) API PHONE-BOOK UP :) :) !", message);
        }
    }
}