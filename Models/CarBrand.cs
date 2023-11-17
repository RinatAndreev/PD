using WebApplication4.Interfaces;

namespace WebApplication4.Models
{
	public class CarBrand
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public List<CarModel>? CarModels { get; set; }

		public string Img { get; set; }

		public double Price { get; set; }

		public long ModelID { get; set; }

		public CarModel carModel { get; set; }

	}
}
