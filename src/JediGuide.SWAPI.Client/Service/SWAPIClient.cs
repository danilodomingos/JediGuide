using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JediGuide.Rest;
using JediGuide.SWAPI.Client.Models;
using Newtonsoft.Json;

namespace JediGuide.SWAPI.Client.Service
{
    public class SWAPIClient
    {
        private readonly HttpClient httpClient;

        private const string URI = "https://swapi.co/api/";
        private const string PLANETS_RESOURCE = "planets/?search={0}";

        public SWAPIClient()
        {
            this.httpClient = new HttpClient();

            this.httpClient.BaseAddress = new Uri(URI);

            this.httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public PaginatorResult<Planet> GetPlanets(string name)
        {
            HttpResponseMessage response = null;
            var paginator = new PaginatorResult<Planet>();
            var urlWithParam = string.Format(PLANETS_RESOURCE, name);

            try
            {
                response = httpClient.GetAsync(urlWithParam).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    var dados = response.Content.ReadAsStringAsync().Result;
                    paginator.Page = JsonConvert.DeserializeObject<PageResult<Planet>>(dados);
                }
            }
            catch (Exception ex){
                paginator.Message = ex.Message;
                //Implementar Log aqui.

            }
            finally{

                paginator.StatusCode = (int)response.StatusCode;
            }

            return paginator;
        }
    }
}