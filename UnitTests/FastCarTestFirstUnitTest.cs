using System;
using NUnit.Framework;
using UnitTestLibrary;

namespace UniteTests
{
	[TestFixture]
	public class FastCarTestFirstUnitTest
	{
		public FastCarTestFirstUnitTest ()
		{
		}

		[Test]
		public void Positive_KindOfCarUnitTest()
		{
			// Given That Speed = 100.00 && HorsePower = 435 @ 6500 (93-octane fuel)
			var expectedResult = "MustangGT";

			TestFirstFastCar appObj = new  TestFirstFastCar ();
			var actualresultObtained = appObj.KindOfCarBasedOnSpeed(100.00);

			Assert.AreEqual(expectedResult, actualresultObtained);
		}

		[Test]
		public void Positive_KindOfCarUnitTestBasedOnHP()
		{
			// Given That Speed = 100.00 && HorsePower = 435 @ 6500 (93-octane fuel)
			var expectedResult = "MustangGT";

			TestFirstFastCar appObj = new  TestFirstFastCar ();
			var actualresultObtained = appObj.KindOfCarBasedOnHorsePower("435 @ 6500 (93-octane fuel)");

			Assert.AreEqual(expectedResult, actualresultObtained);
		}

        [Test]
        public void Negative_ANonexistentEngineTypeDoesNotError()
        {
            // TODO
            /*
             * 
             * SETUP
             * 
             * 
             * ACT
             * 
             * 
             * ASSERT
             */
        }

        [Test]
        public void Negative_ANonexistentHorsePowerDoesNotError()
        {
            // TODO
        }
	}
}

