using Negocio;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class ConectionApi
    {

        public static List<ApiProducts> GetProducts(string url)
        {
            var cliente = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<ApiProducts> products = cliente.Get<List<ApiProducts>>(request);
            return products;
        }

    }
}
