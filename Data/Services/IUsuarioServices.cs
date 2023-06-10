using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public interface IUsuarioServices
	{
		Task<Res<List<UsuarioResponse>>> Consultar(string filtro);
		Task<Res> Crear(UsuarioRequest request);
		Task<Res> Eliminar(UsuarioRequest request);
		Task<Res> Modificar(UsuarioRequest request);
	}
}