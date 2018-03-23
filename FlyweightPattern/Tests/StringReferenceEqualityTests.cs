using System;
using NUnit.Framework;

namespace FlyweightPattern.Tests
{
	//Strings are reference types and two references are only equal if they are refering to the same object
	[TestFixture]
	public class StringReferenceEqualityTests
	{
		
		[Test]
		public void ReferenceEquals_SameObject()
		{
			var s1 = "flyweight";
			var s2 = s1;

			Assert.IsTrue(ReferenceEquals(s1,s2));
		}

		//.NET runtime in order to save space internally manages a string pool and replaces the string with a shared instance
		[Test]
		public void ReferenceEquals_DifferentStrings()
		{
			var s1 = "flyweight";
			var s2 = "flyweight";

			Assert.IsTrue(ReferenceEquals(s1, s2));
		}

		//String.intern returns a reference to an existing string if it is part of the pool - like the flyweight factory created earlier
		[Test, Ignore("Console.Readline will hang. Just wanted to show Intern use")]
		public void ReferenceEquals_StringIntern()
		{
			var s1 = "flyweight";
			var s2 = string.Intern(Console.ReadLine());

			Assert.IsTrue(ReferenceEquals(s1, s2));
		}
	}
}