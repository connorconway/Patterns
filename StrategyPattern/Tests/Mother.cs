﻿using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Tests
{
	public static class Mother
	{
		public static Order CreateOrder() => new Order();
	}
}