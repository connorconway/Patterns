using System;
using StrategyPattern.Functions.Model;

namespace StrategyPattern.Functions.Library
{
	public class ShippingCostCalculator
	{
		public static readonly Func<Order, double> FedExStrategy = o => 5.00d;
		public static readonly Func<Order, double> UpsStrategy = o => 4.25d;
		public static readonly Func<Order, double> UspsStrategy = o => 3.25d;

		public double Cost(Order order, Func<Order, double> shippingMethod) => shippingMethod(order);
	}
}
