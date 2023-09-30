using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public Order FazpagamentoPix(){
			return new Order();
		}

		public Order FazpagamentoCreditCard(){
            return new Order();
        }
		public Order FazpagamentoPaypal(){
            return new Order();
        }

        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			switch (paymentMethod)
			{
				case "pix":
					return FazpagamentoPix();
				case "creditcard":
                    return FazpagamentoCreditCard();
                case "paypal":
                    return FazpagamentoPaypal();
                default:
                    throw new Exception($"Método de pagamento inválido: {paymentMethod}");
            }

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
