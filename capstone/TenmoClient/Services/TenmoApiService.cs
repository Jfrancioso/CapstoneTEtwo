﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TenmoClient.Models;
using TenmoServer.Models;

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

        public decimal GetTransfer(int userId)
        {

            RestRequest restRequest = new RestRequest();
            IRestResponse<decimal> response = client.Get<decimal>(restRequest);

            return response.Data;
        }

        public List<Transfer> GetAllTransfers(int userId)
        {
            List<Transfer> transfers = new List<Transfer>();
            RestRequest restRequest = new RestRequest($"transfer/account/{userId}");
            IRestResponse<List<Transfer>> restResponse = client.Get<List<Transfer>>(restRequest);
            
            return restResponse.Data;
        }

        public List<ApiUser> GetUsers()
        {
            RestRequest request = new RestRequest("user");
            IRestResponse<List<ApiUser>> response = client.Get<List<ApiUser>>(request);

            return response.Data;
        }

        public Transfer SendTransfer (Transfer transfer)
        {
            RestRequest request = new RestRequest("transfer");
            request.AddJsonBody(transfer);

            IRestResponse<Transfer> response = client.Post<Transfer>(request);

            return response.Data;
        }

        public Account GetAccount(int userId)
        {
            RestRequest request = new RestRequest($"user/{userId}");

            IRestResponse<Account> response = client.Get<Account>(request);

            return response.Data;
        }

    }
}
