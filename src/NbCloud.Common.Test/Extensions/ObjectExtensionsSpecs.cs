using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common.Extensions
{
    [TestClass]
    public class ObjectExtensionsSpecs
    {
        [TestMethod]
        public void ToSplits_Default_Should_Auto_Trim()
        {
            var jan = new Foo();

            jan.Age = 24;
            jan.DynamicProperties().SomeValue = 27;
            jan.LogJson();

            Assert.AreEqual(24, jan.Age);
            Assert.AreEqual(27, jan.DynamicProperties().SomeValue);
            jan = null; // NumberOfDrinkingBuddies will also be erased during garbage collection
        }

        public class Foo
        {
            public int Age { get; set; }
        }
    }
}
