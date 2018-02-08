using System;
using StrategyPattern.Model;

namespace StrategyPattern.Library
{
	public class ShippingCostCalculator
	{
		public double Cost(Order order)
		{
			switch (order.ShippingMethod)
			{
				case Order.ShippingOption.FedEx:
					return CostForFedEx(order);
				case Order.ShippingOption.Ups:
					return CostForUPS(order);
				case Order.ShippingOption.Usps:
					return CostForUSPS(order);
				default:
					throw new ArgumentException();
			}
		}

		private double CostForUSPS(Order order)
		{
			return 3.00d;
		}

		private double CostForUPS(Order order)
		{
			return 4.25d;
		}

		private double CostForFedEx(Order order)
		{
			return 5.00d;
		}
	}
}