using System;
using NUnit.Framework;
using UnitTestLibrary;

namespace UniteTests
{
    [TestFixture]
    public class FastCarUnitTest
    {
        //GetKindOfCar
        [Test]
        public void TestCase()
        {
        }

        [TestFixtureSetUp]
        public void testsomething()
        {
        
        }

        /// <summary>
        ///
        ///</summary>
        [Test]
        public void PositiveScenarioForChecking_KindOfCar()
        {
            var appObject = new UnitTestFastCarLibrary();
            appObject.GetKindOfCar(1, 1);

            Assert.AreNotEqual("Say Wat?", appObject.GetKindOfCar(1, 1));
        }

        [TestCase(1, 1, Result = "So you got => MustangV6 of horse power 300 hp @ 6500 with engineType 3.7L Ti-VCT V-6 Engine")]
        [TestCase(2, 2, Result = "So you got => MustangEcoBoost of horse power 310 @ 5500 (93-octane fuel) with engineType 2.3L GTDI I-4 Engine")]
        [TestCase(3, 3, Result = "So you got => MustangGT of horse power 310 @ 5500 (93-octane fuel) with engineType 2.3L GTDI I-4 Engine")]
        public string PositiveScenarioForChecking_KindOfCar(int a, int b)
        {
            var appObject = new UnitTestFastCarLibrary();
            var actualResult = appObject.GetKindOfCar(a, b);

            return actualResult;
        }

        /// <summary>
        ///
        ///</summary>
        [Test]
        public void NegativeScenarioForChecking_KindOfCar()
        {
            var appObject = new UnitTestFastCarLibrary();
            var actualResult = appObject.GetKindOfCar(1, 2);

            Assert.AreEqual("Say Wat?", actualResult);
        }

        /// <summary>
        ///
        ///</summary>
        [Test]
        public void PostiveScenarioForChecking_SpeedOfCar()
        {
            var appObject = new UnitTestFastCarLibrary();
            var actualResult = appObject.GetSpeedOfCar(100);

            Assert.AreEqual(VehicleSpeedEnumeration.NormalSpeed, actualResult);
        }

        [Test]
        public void NegativeScenarioForChecking_SpeedOfCar()
        {
            var appObject = new UnitTestFastCarLibrary();
            var actualResult = appObject.GetSpeedOfCar(120);

            Assert.AreNotEqual(VehicleSpeedEnumeration.NormalSpeed, actualResult);
        }

    }
}