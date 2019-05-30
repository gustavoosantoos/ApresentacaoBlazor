using ApresentacaoBlazor.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApresentacaoBlazor.Pages
{
    public class FetchDataComponent : ComponentBase
    {
        [Inject] protected HttpClient Http { get; set; }

        protected WeatherForecast[] Forecasts { get; set; }

        protected override async Task OnInitAsync()
        {
            Forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            Console.WriteLine("Testes");
        }
    }
}
