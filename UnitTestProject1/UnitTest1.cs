using BlazorBloggerApi3.Models.Extensions;
using BlazorBloggerApi3.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExtensionedClientResponse()
        {
            //var instance = BlazorBloggerApiService.GetInstance("AIzaSyACJeX9O_f6P38B1OSZRNrKyAAeOblb3q4");
            var client = new HttpClient();
            var response = client.GetJsonAsync<BlazorBloggerApi3.Models.Result.PostListResult>("https://www.googleapis.com/blogger/v3/blogs/3213900/posts?key=AIzaSyACJeX9O_f6P38B1OSZRNrKyAAeOblb3q4").GetAwaiter().GetResult();
            Assert.IsTrue(response.IsStatusCodeSuccess);
        }
    }
}
