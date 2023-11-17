using WebApplication4.Interfaces;
using WebApplication4.Models;

namespace WebApplication4.Services
{
	public class CarBrandService : ICarBrand
	{
		public IEnumerable<CarBrand> CarBrands
		{
			get
			{
				return new List<CarBrand>()
				{
				new CarBrand()
				{
				Name = "BMW",
				Description = "325d",
				Img = "https://www.cars.com/i/large/in/v2/stock_photos/79ad212a-405c-4718-804a-f494d11dfac8/d6555e05-b1e7-4341-8c6f-141ff1eb86a2.png",
				Price = 7000,
				Id = 1

				},
				new CarBrand()
				{
				Name = "Audi",
				Description = "A6",
				Img = "https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/gallery_slide/public/images/car-reviews/first-drives/legacy/audi_a6_avant_drive_026.jpg?itok=uzmWbqBa",
				Price = 20000,
				Id = 2
				}
				};
			}
		}

		public IEnumerable<CarBrand> AllCarBrands { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
