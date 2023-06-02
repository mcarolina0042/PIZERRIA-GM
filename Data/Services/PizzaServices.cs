using Microsoft.EntityFrameworkCore;
using PIZERRIAGM.Data.Context;
using PIZERRIAGM.Data.Entities;
using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Services
{
	public class Resu
	{
		public bool Success { get; set; }
		public string? Message { get; set; }

	}
	public class Resu<T>
	{
		public bool Success { get; set; }
		public string? Message { get; set; }
		public T? Data { get; set; }
	}
	public class PizzaServices
	{
		private readonly IMyDbContext dbContext;

		public PizzaServices(IMyDbContext dbContext)
        {
			this.dbContext = dbContext;
		}

		public async Task<Resu> Crear(PizzaRequest request)
		{
			try
			{
				var pizza = Pizza.Crear(request);
				dbContext.Pizzas.Add(pizza);
				await dbContext.SaveChangesAsync();
				return new Resu() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Resu() { Message = E.Message, Success = false };
			}
		}

		public async Task<Resu> Modificar(PizzaRequest request)
		{
			try
			{
				var pizza = await dbContext.Pizzas.FirstOrDefaultAsync(d => d.Id == request.Id);
				if (pizza == null)
					return new Resu() { Message = "No Se Encontro El Cliente ", Success = false };

				if (pizza.Modificar(request))
					await dbContext.SaveChangesAsync();

				return new Resu() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Resu() { Message = E.Message, Success = false };
			}
		}

		public async Task<Resu> Eliminar(PizzaRequest request)
		{
			try
			{
				var pizza = await dbContext.Pizzas.FirstOrDefaultAsync(d => d.Id == request.Id);
				if (pizza == null)
					return new Resu() { Message = "No Se Encontro La Factura ", Success = false };

				dbContext.Pizzas.Remove(pizza);
				await dbContext.SaveChangesAsync();

				return new Resu() { Message = "OK", Success = true };
			}

			catch (Exception E)
			{
				return new Resu() { Message = E.Message, Success = false };
			}
		}

		public async Task<Resu<List<PizzaResponse>>> Consultar(string filtro)
		{
			try
			{
				var pizzas = await dbContext.Pizzas
					.Where(d =>
						(d.Nombre + " " + d.Tamaño + " " + d.Precio)
						.ToLower()
						.Contains(filtro.ToLower()
						)
					)
					.Select(d => d.ToResponse())
					.ToListAsync();
				return new Resu<List<PizzaResponse>>()
				{
					Message = "Ok",
					Success = true,
					Data = pizzas
				
				};
			}
			catch (Exception E)
			{
				return new Resu<List<PizzaResponse>>
				{
					Message = E.Message,
					Success = false
				};
			}
		}
	}
}
