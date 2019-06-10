using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace App1.API
{
    public static class NetworkService
    {
        public static IEndpoint endpoint;
        public static string baseURL = "http://sikka-aceh.com/api";
        public static IEndpoint GetEndpoint()
        {
            var httpLog = new HttpClient(new HttpLoggingHandler()) { BaseAddress = new Uri(baseURL) };
            endpoint = RestService.For<IEndpoint>(httpLog);
            return endpoint;
        }
    }
}
