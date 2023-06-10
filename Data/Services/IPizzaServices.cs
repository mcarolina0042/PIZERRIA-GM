using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public interface IPizzaServices
	{
		Task<Resu<List<PizzaResponse>>> Consultar(string filtro);
		Task<Resu> Crear(PizzaRequest request);
		Task<Resu> Eliminar(PizzaRequest request);
		Task<Resu> Modificar(PizzaRequest request);
	}
}