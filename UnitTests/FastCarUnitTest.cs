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
        public void PossitiveScenarioForChecking_KindOfCar()
        {

            var appObject = new UnitTestFastCarLibrary();
            appObject.GetKindOfCar(1, 1);

            Assert.AreNotEqual("Say Wat?", appObject.GetKindOfCar(1, 1));
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