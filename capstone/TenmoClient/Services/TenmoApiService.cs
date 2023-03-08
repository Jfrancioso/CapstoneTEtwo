using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TenmoClient.Models;
 

namespace TenmoClient.Services
{
    public class TenmoApiService : AuthenticatedApiService
    {
        public readonly string ApiUrl;

        public TenmoApiService(string apiUrl) : base(apiUrl) { }

        public Account GetBalance(int userId)
        
        {
            RestRequest restRequest = new RestRequest($"account/{userId}");
            IRestResponse<Account> response = client.Get<Account>(restRequest);

                return response.Data;
          
        }

    }
}
