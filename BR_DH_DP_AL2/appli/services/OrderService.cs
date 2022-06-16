using System;
namespace BR_DH_DP_AL2.appli.services
{
	public class OrderService
	{
		public OrderService()
		{
		}

        public double getPriceOrder(List<Sandwich> _sandwiches)
        {
            double priceOrder = 0;
            foreach (Sandwich sandwich in _sandwiches)
            {
                priceOrder += sandwich.Price;
            }

            return priceOrder;
        }
    }
}

