using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizza.Services;

namespace pizza.Controllers
{
    [ApiController]
[Route("api/[controller]")]
public class PizzaController : ControllerBase
{
		private readonly IStoreService _pizzaStore;
		private readonly ILogger<PizzaController> _logger;

		public PizzaController(ILogger<PizzaController> logger, IStoreService pizzaStore)
        {
            _logger = logger;
            _pizzaStore = pizzaStore;
        }
		
		// GET - hamma pitsa turlarini qaytaradi

		// GET - idsiga qarab pitsa qaytaradi

		// POST - yangi pitsa turini yaratadi

		// PUT - berilgan pitsani o'zgartiradi

		// DELETE - berilgan idga ega pitsani o'chirib yuboradi
}
}