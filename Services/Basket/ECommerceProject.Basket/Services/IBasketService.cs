using ECommerceProject.Basket.Dtos;

namespace ECommerceProject.Basket.Services
{
	public interface IBasketService
	{
		Task<BasketTotalDto> GetBasketTotalDtoAsync(String UserID);
		Task SaveBasket(BasketTotalDto basket);
		Task DeleteBasket(String UserID);
	}
}
