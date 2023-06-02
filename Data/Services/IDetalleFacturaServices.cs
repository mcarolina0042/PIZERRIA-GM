using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public interface IDetalleFacturaServices
	{
		Task<Result<List<DetalleFacturaResponse>>> Consultar(string filtro);
		Task<Results> Crear(DetalleFacturaRequest request);
		Task<Results> Eliminar(DetalleFacturaRequest request);
		Task<Results> Modificar(DetalleFacturaRequest request);
	}
}