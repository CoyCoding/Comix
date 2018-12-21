using Comix.Models;
using Marvel.Api;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Comix.Infrastructure
{
    public static class ApiHelper
    {
        const string MarvelpublicKey = "111";
        const string MarvelprivateKey = "111";
        const string HeroKey = "2000";

        public static MarvelRestClient MarvelClient { get; set; }

        public static PowerLevelApiClient HeroContext { get; set; }

        public static void InitializeClient()
        { 
            MarvelClient = new MarvelRestClient(MarvelpublicKey, MarvelprivateKey);
            HeroContext = new PowerLevelClient(HeroKey);
            
        }
    }


}