using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Comix.Models
{
    public abstract class PowerLevelApiClient
    {

        protected readonly string Key;
        protected readonly WebClient HeroClient;

        public string BaseUrl { get; set; }

        protected PowerLevelApiClient(string key)
        {
            this.Key = key;
            HeroClient = new WebClient(); 
        }

        internal string GetCharaterId(string name)
        {
            var data = new Uri("https://superheroapi.com/api.php/2000160380031550/search/spider-man");
            var response = HeroClient.DownloadString(data);
            
        
            return response;
        }
    }
}