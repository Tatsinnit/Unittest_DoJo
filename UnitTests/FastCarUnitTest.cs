using System;
using NUnit.Framework;

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
        /// 
        [Test]
        public void PossitiveScenarioForChecking_KindOfCar()
        {

            UnitTestLibrary.UnitTestFastCarLibrary appObject = new UnitTestLibrary.UnitTestFastCarLibrary();
            appObject.GetKindOfCar(1, 1);

            Assert.AreNotEqual("Say Wat?", appObject.GetKindOfCar(1, 1));
        }

        /// <summary>
        ///
        ///</summary>
        /// 
        [Test]
        public void NegativeScenarioForChecking_KindOfCar()
        {
            UnitTestLibrary.UnitTestFastCarLibrary appObject = new UnitTestLibrary.UnitTestFastCarLibrary();
            var actualResult = appObject.GetKindOfCar(1, 2);

            Assert.AreEqual("Say Wat?", actualResult);
        }
    }
}