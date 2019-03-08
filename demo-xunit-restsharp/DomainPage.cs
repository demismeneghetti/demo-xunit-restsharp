using FluentAssertions;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
            statusCode.Should().BeEquivalentTo(HttpStatusCode.OK);

            //dynamic json = JValue.Parse(response.Content);
            //string body = json;
            //body.Should().BeEquivalentTo("! :) :) API PHONE-BOOK UP :) :) ");
        }
    }
}