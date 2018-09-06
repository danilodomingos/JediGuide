using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JediGuide.SWAPI.Client.Models;
using Newtonsoft.Json;

namespace JediGuide.SWAPI.Client.Service
{
    public class SWAPIClient
    {
        private readonly HttpClient httpClient;

        private const string URI = "https://swapi.co/api/";
        private const string PLANETS_RESOURCE = "planets";
        private const string FILMS_RESOURCE = "films";

        public SWAPIClient()
        {
            this.httpClient = new HttpClient();

            this.httpClient.BaseAddress = new Uri(URI);

            this.httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<PaginatorResult<Planet>> GetPlanetsAsync()
        {
            HttpResponseMessage response = null;
            var paginator = new PaginatorResult<Planet>();

            try
            {
                response = await httpClient.GetAsync("planets");
                if (response.IsSuccessStatusCode)
                {
                    var dados = await response.Content.ReadAsStringAsync();
                    paginator = JsonConvert.DeserializeObject<PaginatorResult<Planet>>(dados);
                }
            }
            catch (Exception ex){

            }
            finally{
                paginator.StatusCode = (int)response.StatusCode;
            }

            return paginator;
        }

        public async Task<PaginatorResult<Film>> GetFilms()
        {
            HttpResponseMessage response = null;
            var paginator = new PaginatorResult<Film>();

            try
            {
                response = await httpClient.GetAsync("films");
                if (response.IsSuccessStatusCode)
                {
                    var dados = await response.Content.ReadAsStringAsync();
                    paginator = JsonConvert.DeserializeObject<PaginatorResult<Film>>(dados);
                }
            }
            catch (Exception ex){

            }
            finally{
                paginator.StatusCode = (int)response.StatusCode;
            }


            return paginator;
        }
    }
}