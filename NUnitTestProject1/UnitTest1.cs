using NUnit.Framework;
using Coffee;
using RestSharp;
using System.Net;
using System;

namespace NUnitTestProject1
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {

      //Arrange
      var URL = "https://goodie.pl";
      var client = new RestClient(URL);
      var request = new RestRequest("unknown", Method.GET);
      //Act
      IRestResponse response = client.Execute(request);
      var content = response.Content;

      //Assert
      Assert.NotNull(content);
      Assert.AreEqual(HttpStatusCode.OK,response.StatusCode);
      Console.Write(content);


    }
  }
}