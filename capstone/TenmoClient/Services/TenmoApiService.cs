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

        public decimal GetBalance(int userId)
        
        {
            RestRequest restRequest = new RestRequest($"account/{userId}");
            IRestResponse<decimal> response = client.Get<decimal>(restRequest);

                return response.Data;
          
        }

        //public decimal GetTransfer(int userId)
        //{

        //    //RestRequest restRequest = new RestRequest()
        //    //IRestResponse<decimal> response = client.Get<decimal>(restRequest)

        //    //    return response.Data;
        //}

    }
}
