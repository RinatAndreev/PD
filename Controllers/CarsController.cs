using Microsoft.AspNetCore.Mvc;
using WebApplication4.Interfaces;

namespace WebApplication4.Controllers
{
	public class CarsController : Controller
	{
		public readonly ICarModel _carModels;
		public readonly ICarBrand _carBrands;
		public CarsController(ICarModel carModels, ICarBrand carBrands)
		{
			_carModels = carModels;
			_carBrands = carBrands;
		}
		public ViewResult AllModels()
		{
			var carModels = _carModels.AllCarModels;
			return View(carModels);
		}
		public ViewResult CarBrand()
		{
			var carBrands = _carBrands.AllCarBrands;
			return View(carBrands);
		}

	}
}
