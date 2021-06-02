using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace Vedroid.Api.Tests
{
    public class Tests
    {
        public HttpClient HttpClient { get; }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetAllDrinksTest()
        {
            using var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://localhost:5001/drink/get");
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
        [Test]
        public async Task EbanutPivandepalaTest()
        {
            using var httpClient = new HttpClient();

            var result = await httpClient.GetAsync("https://localhost:5001/drink/pivo");
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}