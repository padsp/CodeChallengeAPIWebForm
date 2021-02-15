﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace CodeChallengeAPIWebForm
{
    public class APIHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}