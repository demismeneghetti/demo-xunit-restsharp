using FluentAssertions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit.Abstractions;

namespace PhoneBookTest
{
    public class ContactsPage
    {
        public void PutContact(string id, string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var client = new RestClient($"{DomainPage.URL}/contacts/{id}");
            var request = new RestRequest(Method.PUT);

            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, mobilephone, homephone });
            
            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            statusCode.Should().BeEquivalentTo(code); 
        }
        public void GetDomain()
        {
            RestClient client = new RestClient($"{DomainPage.URL}/contacts");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            statusCode.Equals(HttpStatusCode.OK);
            statusCode.Should().BeEquivalentTo("! :) :) API PHONE-BOOK UP :) :) ");
        }
        public void PostContact(string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var client = new RestClient($"{DomainPage.URL}/contacts");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, mobilephone, homephone });

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            statusCode.Should().BeEquivalentTo(code);
        }
    }
}
