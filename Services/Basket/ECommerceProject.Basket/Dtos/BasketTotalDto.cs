namespace ECommerceProject.Basket.Dtos
{
    public class BasketTotalDto
    {
        public string UserID { get; set; }
        public string DiscountCode {  get; set; }
        public int DiscountRate { get; set; }
        public List<BasketitemDto> basketitems { get; set; }
        public decimal TotalPrice {  get=>basketitems.Sum(x=>x.Price*x.Quantity); }
    }
}
