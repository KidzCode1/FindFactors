using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MathLibrary;


namespace FactorTest
{
	[TestClass]
	public class FactorTests
	{
		[TestMethod]
		public void TestIsFactor()
		{
			Assert.IsTrue(SuperMath.IsFactor(25, 5));
			Assert.IsFalse(SuperMath.IsFactor(25, 3));
			Assert.IsTrue(SuperMath.IsFactor(9, 3));
			Assert.IsFalse(SuperMath.IsFactor(7, 3));
			Assert.IsTrue(SuperMath.IsFactor(8, 2));
			Assert.IsTrue(SuperMath.IsFactor(10, 2));
		}

		[TestMethod]
		public void TestGetFactors()
		{
			List<int> factors = SuperMath.GetFactors(6);
			Assert.AreEqual(2, factors.Count);
			Assert.AreEqual(2, factors[0]);
			Assert.AreEqual(3, factors[1]);

			factors = SuperMath.GetFactors(10);
			Assert.AreEqual(2, factors.Count);
			Assert.AreEqual(2, factors[0]);
			Assert.AreEqual(5, factors[1]);

			factors = SuperMath.GetFactors(9);
			Assert.AreEqual(2, factors.Count);
			Assert.AreEqual(2, factors.FindAll(x => x == 3).Count);

			factors = SuperMath.GetFactors(8);
			Assert.AreEqual(3, factors.Count);
			Assert.AreEqual(3, factors.FindAll(x => x == 2).Count);
		}
		[TestMethod]
		public void TestFactorOfOne()
		{
			List<int> factors = SuperMath.GetFactors(1);
			Assert.AreEqual(1, factors.Count);
			Assert.AreEqual(1, factors[0]);
		}
	}
}
