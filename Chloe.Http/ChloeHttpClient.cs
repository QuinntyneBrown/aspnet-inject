using Chloe.Http.Contracts;
using System;
using System.Net.Http;

namespace Chloe.Http
{
    public class ChloeHttpClient : HttpClient, IChloeHttpClient
    {
        public T Get<T>(string requestUrl){
            var response = this.GetAsync(new Uri(requestUrl)).Result;
            return response.Content.ReadAsAsync<T>().Result;
        }
    }
}
