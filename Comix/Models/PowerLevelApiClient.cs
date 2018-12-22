using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Comix.Models
{
    public class PowerLevelApiClient
    {

        private readonly string Key;
        private readonly WebClient HeroClient;

        public string BaseUrl { get; set; }

        public PowerLevelApiClient(string key)
        {
            this.Key = key;
            HeroClient = new WebClient(); 
        }

        internal object GetCharaterId(string name)
        {
            var uri = "https://superheroapi.com/api.php/" + Key + "/search/" + name;
            var stringResponse = HeroClient.DownloadString(new Uri(uri));
            return new JavaScriptSerializer().Deserialize<object>(stringResponse);
        }

        
    }
}