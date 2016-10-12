using System;
using LemonWay.Business;
using LemonWayService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.Test
{
	[TestClass]
	public class FibonacciTests
	{
		[TestMethod]
		public void Fibonnacci_With_One_Return_One()
		{
			Assert.AreEqual(MathFunction.Fibonnaci(1), 1);
		}

		[TestMethod]
		public void Fibonnacci_With_Zero_Return_Minus_One()
		{
			Assert.AreEqual(MathFunction.Fibonnaci(0), -1);
		}

		[TestMethod]
		public void Fibonnacci_With_Wrong_Value_Return_Minus_One()
		{
			Assert.AreEqual(MathFunction.Fibonnaci(new Random().Next() * -1), -1);
		}

		[TestMethod]
		public void Fibonnacci_With_Six_Return_Eight()
		{
			Assert.AreEqual(MathFunction.Fibonnaci(6), 8);
		}
	}
}
