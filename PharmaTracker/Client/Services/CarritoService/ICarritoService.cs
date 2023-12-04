using PharmaTracker.Shared;

namespace PharmaTracker.Client.Services.CarritoService
{
	public interface ICarritoService
	{
		event Action OnChange;
		Task AgregarAlCarrito(Productos producto);
		Task<List<ArticulosEnCarrito>> ObtenerArticulosEnCarrito();
		Task EliminarArticulo(ArticulosEnCarrito articulo);
		Task Guardar(ArticulosEnCarrito articulo);

	}
}
