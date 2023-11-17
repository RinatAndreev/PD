using WebApplication4.Models;

namespace WebApplication4.Interfaces
{
	public interface ICarModel
	{
		IEnumerable<CarModel> AllCarModels(CarBrand CarBrand);
	}
}
