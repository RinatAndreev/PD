using WebApplication4.Interfaces;
using WebApplication4.Models;

namespace WebApplication4.Services
{
	public class CarModelService : ICarModel
	{
		public IEnumerable<CarModel> AllCategories
		{
			get
			{
				return new List<CarModel>()
				{
				new CarModel()
				{
				Name = "Sedan",
				Description = "4-door passenger car"
				},
				new CarModel()
				{
				Name = "Hatchback",
				Description = "More available trunk space"
				}
				};
			}
		}

		public IEnumerable<CarModel> AllCarModels(CarBrand CarBrand)
		{
			throw new NotImplementedException();
		}
	}
}
