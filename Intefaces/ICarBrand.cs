using WebApplication4.Models;

namespace WebApplication4.Interfaces
{
	public interface ICarBrand
	{

		IEnumerable<CarBrand> AllCarBrands { get; set; }
	}
}
