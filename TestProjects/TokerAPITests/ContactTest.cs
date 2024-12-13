using NUnit.Framework;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
//using TokerAPI;


namespace TokerAPITests;
    public class ContactTest
{
    //private readonly HttpClient _client;
    //private readonly WebApplicationFactory<TokerAPITests.Startup> _factory;

    public ContactTest() {
        //_factory = new WebApplicationFactory<TokerAPI.Startup>();
        //_client = _factory.CreateClient();
    }

    /*[Test]
    public async Task TestNewContact()
    {
        var newContact = new {
            ContactName = "Andres Ibarra",
            ContactPhone = "3058683181"
        };
        var response = await  _client.PostAsJsonAsync("/api/contact/sendcontact", newContact);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Equals("Registration Succesfully", responseString);
    } */

    //[OneTimeTearDown] public void Cleanup() { _client.Dispose(); _factory.Dispose(); }
}


