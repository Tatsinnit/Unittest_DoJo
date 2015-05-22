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
        ///A test for combineArrayStringWithSpace
        ///</summary>
        /// 
        [Test]
        public void PossitiveScenarioForChecking_KindOfCar()
        {

            UnitTestLibrary.UnitTestFastCarLibrary appObject = new UnitTestLibrary.UnitTestFastCarLibrary();
            appObject.GetKindOfCar(1, 1);

            Assert.AreNotEqual("Say Wat?", appObject.GetKindOfCar(1, 1));
        }


    }
}