using Microsoft.EntityFrameworkCore;
using PIZERRIAGM.Data.Context;
using PIZERRIAGM.Data.Entities;
using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public class Results
	{
		public bool Success { get; set; }
		public string? Message { get; set; }

	}
	public class Results<T>
	{
		public bool Success { get; set; }
		public string? Message { get; set; }
		public T? Data { get; set; }
	}

	public class DetalleFacturaServices : IDetalleFacturaServices
	{
		private readonly IMyDbContext dbContext;

		public DetalleFacturaServices(IMyDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<Results> Crear(DetalleFacturaRequest request)
		{
			try
			{
				var detalleFactura = DetalleFactura.Crear(request);
				dbContext.DetalleFacturas.Add(detalleFactura);
				await dbContext.SaveChangesAsync();
				return new Results() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Results() { Message = E.Message, Success = false };
			}
		}

		public async Task<Results> Modificar(DetalleFacturaRequest request)
		{
			try
			{
				var detalleFactura = await dbContext.DetalleFacturas.FirstOrDefaultAsync(c => c.Id == request.Id);
				if (detalleFactura == null)
					return new Results() { Message = "No Se Encontro El DetalleFactura ", Success = false };

				if (detalleFactura.Modificar(request))
					await dbContext.SaveChangesAsync();

				return new Results() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Results() { Message = E.Message, Success = false };
			}
		}

		public async Task<Results> Eliminar(DetalleFacturaRequest request)
		{
			try
			{
				var detalleFactura = await dbContext.DetalleFacturas.FirstOrDefaultAsync(c => c.Id == request.Id);
				if (detalleFactura == null)
					return new Results() { Message = "No Se Encontro El Cliente ", Success = false };

				dbContext.DetalleFacturas.Remove(detalleFactura);
				await dbContext.SaveChangesAsync();

				return new Results() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Results() { Message = E.Message, Success = false };
			}
		}

		public async Task<Result<List<DetalleFacturaResponse>>> Consultar(string filtro)
		{
			try
			{
				var detalleFacturas = await dbContext.DetalleFacturas
					.Where(d =>
						(d.FacturaId + " " + d.Factura + " " + d.PizzaId + " " + d.Pizza + " " + d.Cantidad + "" + d.Precio)
						.ToLower()
						.Contains(filtro.ToLower()
						)
					)
					.Select(d => d.ToResponse())
					.ToListAsync();
				return new Result<List<DetalleFacturaResponse>>()
				{
					Message = "Ok",
					Success = true,
					Data = detalleFacturas
				};
			}
			catch (Exception E)
			{
				return new Result<List<DetalleFacturaResponse>>
				{
					Message = E.Message,
					Success = false
				};
			}
		}
	}
}
