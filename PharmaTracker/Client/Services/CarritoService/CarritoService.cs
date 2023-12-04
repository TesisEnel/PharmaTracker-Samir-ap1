using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using PharmaTracker.Client.Services.ProductosService;
using PharmaTracker.Shared;
using Radzen;

namespace PharmaTracker.Client.Services.CarritoService
{
	public class CarritoService : ICarritoService
	{
		private readonly ISessionStorageService _sessionStorageService;
		private readonly IProductosService _productosService;

		public event Action OnChange;
        public CarritoService(ISessionStorageService sessionStorageService,
			IProductosService productosService)
        {
			_sessionStorageService = sessionStorageService;
			_productosService = productosService;
		}

        public async Task AgregarAlCarrito(Productos producto)
		{
			var carrito = await _sessionStorageService.GetItemAsync<List<Productos>>("carrito");
			if (carrito == null)
			{
				carrito = new List<Productos>();
			}
			carrito.Add(producto);
			await _sessionStorageService.SetItemAsync("carrito", carrito);

			OnChange?.Invoke();
		}

        public async Task<List<ArticulosEnCarrito>> ObtenerArticulosEnCarrito()
        {
            var resultado = new List<ArticulosEnCarrito>();
			var carrito = await _sessionStorageService.GetItemAsync<List<Productos>>("carrito");
			if (carrito == null)
				return resultado;

			foreach (var producto in carrito)
			{
				var articulo = await _productosService.ObtenerProductos(producto.ProductoId);
				var articuloEnCarrito = new ArticulosEnCarrito
				{
					ProductoId = articulo.ProductoId,
					NombreProducto = articulo.NombreProducto,
					Precio = articulo.Precio,
					Imagen = articulo.Imagen,
                };
				resultado.Add(articuloEnCarrito);
			}
			return resultado;
        }

        public async Task EliminarArticulo(ArticulosEnCarrito articulo)
        {
            var carrito = await _sessionStorageService.GetItemAsync<List<Productos>>("carrito");
			if (carrito == null)
				return;
			var articuloAEliminar = carrito.Find(x => x.ProductoId == articulo.ProductoId);
			carrito.Remove(articuloAEliminar);

			await _sessionStorageService.SetItemAsync("carrito", carrito);

			OnChange?.Invoke();
        }
    }
}
