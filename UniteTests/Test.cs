using System;
using NUnit.Framework;

namespace UniteTests
{
	[TestFixture()]
	public class Test
	{
		private string expectedResult = "";

		[Test ()]
		public void TestCase ()
		{
		}

		[TestFixtureSetUp()]
		public void testsomething()
		{
			 expectedResult = "Today is the wonderful day of my life";
		}
		/// <summary>
		///A test for combineArrayStringWithSpace
		///</summary>
		/// 
		[Test]
		public void PossitiveScenarioForChecking_combineArrayStringWithSpace()
		{
			
			string[] actualStringArray = new string[] { "Today", "is", "the", "wonderful", "day", "of", "my", "life" };
			UnitTestLibrary.UnitTestStringLibrary appObject = new UnitTestLibrary.UnitTestStringLibrary();

			string actualResult = appObject.combineArrayStringWithSpace(actualStringArray);
			Console.WriteLine(actualResult + " ==== " + expectedResult);
			Assert.AreEqual(expectedResult, actualResult);
		}

	}

}

