using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LasPisadasClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<Zapato> Zapatos { get; private set; } = new List<Zapato>();
        public string MensajeError { get; private set; }

        public async Task OnGetAsync()
        {
            var cliente = _httpClientFactory.CreateClient();
            var respuesta = await cliente.GetFromJsonAsync<List<Zapato>>("https://localhost:7048/api/Zapatos");

            if (respuesta != null)
            {
                Zapatos = respuesta;
            }
            else
            {
                MensajeError = "Error al obtener los zapatos";
            }
        }

        public class Zapato
        {
            public int IdZapato { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string DescripcionCorta { get; set; }
            public string DescripcionDetallada { get; set; }
            public decimal Precio { get; set; }
        }
    }
}
