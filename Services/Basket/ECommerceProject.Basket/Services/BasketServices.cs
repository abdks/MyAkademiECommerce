using ECommerceProject.Basket.Dtos;

namespace ECommerceProject.Basket.Services
{
	public class BasketServices : IBasketService
	{
		//private readonly 
		public Task DeleteBasket(string UserID)
		{
			throw new NotImplementedException();
		}

		public Task<BasketTotalDto> GetBasketTotalDtoAsync(string UserID)
		{
			throw new NotImplementedException();
		}

		public Task SaveBasket(BasketTotalDto basket)
		{
			throw new NotImplementedException();
		}
	}
}
