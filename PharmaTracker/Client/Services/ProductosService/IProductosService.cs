using PharmaTracker.Shared;

namespace PharmaTracker.Client.Services.ProductosService
{
	public interface IProductosService
	{
		event Action OnChange;

		List<Productos> Productos { get; set; }

		Task CargarProductos();

		Task<Productos> ObtenerProductos(int id);
	}
}
