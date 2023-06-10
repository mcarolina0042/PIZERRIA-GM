using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public interface IFacturaServices
	{
		Task<Resul<List<FacturaResponse>>> Consultar(string filtro);
		Task<Resul> Crear(FacturaRequest request);
		Task<Resul> Eliminar(FacturaRequest request);
		Task<Resul> Modificar(FacturaRequest request);
	}
}