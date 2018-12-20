using Marvel.Api;
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
     

        public static MarvelRestClient MarvelClient { get; set; }

        public static void InitializeClient()
        { 
            MarvelClient = new MarvelRestClient(publicKey, privateKey);
        }
    }
}