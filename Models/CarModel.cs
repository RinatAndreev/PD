using WebApplication4.Models;

namespace WebApplication4.Models
{
	public class CarModel
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
	}
}


namespace WebApplication4.Views.Cars
{
    public class CarsBrandsModel
    {
        public List<CarBrand> CarBrands { get; set; }
    }
}
