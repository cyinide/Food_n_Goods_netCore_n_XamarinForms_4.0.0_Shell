using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FoodsNGoods.Client
{
    public class BaseClient
    {
        private static string LocalEndPoint = "http://192.168.0.13:5000";

        public static ApiClient Client
        {
            get
            {
                var client = new ApiClient(GetLocalEndPoint(), new HttpClient()); //No need for httpclient in ApiClient class? Remove it?
                return client;
            }
        }

        private static string GetLocalEndPoint()
        {
            return LocalEndPoint;
        }
    }
}
