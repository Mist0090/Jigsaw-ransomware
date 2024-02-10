using System;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Main.Tools
{
    internal static class Blockr
    {
        private static string BlockrAddress => "http://btc.blockr.io/api/v1/";

        internal static double GetPrice()
        {
            string request = BlockrAddress + "coin/info/";
            WebClient client = new WebClient();
            string result = client.DownloadString(request);

            JObject json = JObject.Parse(result);
            JToken status = json["status"];
            if ((status != null && status.ToString() == "error"))
            {
                throw new Exception(json.ToString());
            }

            return json["data"]["markets"]["coinbase"].Value<double>("value");
        }

        internal static double GetBalanceBtc(string address)
        {
            string request = BlockrAddress + "address/balance/" + address;
            WebClient client = new WebClient();
            string result = client.DownloadString(request);

            JObject json = JObject.Parse(result);
            JToken status = json["status"];
            if ((status != null && status.ToString() == "error"))
            {
                throw new Exception(json.ToString());
            }

            return json["data"].Value<double>("balance");
        }
    }
}