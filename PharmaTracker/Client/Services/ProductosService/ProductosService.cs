using PharmaTracker.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace PharmaTracker.Client.Services.ProductosService
{
	public class ProductosService : IProductosService
	{
		private readonly HttpClient _http;

		public event Action OnChange;
		public List<Productos> Productos { get; set; } = new List<Productos>();
		public ProductosService(HttpClient http)
		{
			_http = http;
		}

		public async Task CargarProductos()
		{
			Productos = await _http.GetFromJsonAsync<List<Productos>>("api/Productos");
			OnChange?.Invoke();
		}
		public async Task<Productos> ObtenerProductos(int id)
		{
			return await _http.GetFromJsonAsync<Productos>($"api/Productos/{id}");
		}
	}
}
