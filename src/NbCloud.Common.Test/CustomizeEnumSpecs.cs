using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common
{
    [TestClass]
    public class CustomizeEnumSpecs
    {
        [TestMethod]
        public void GetAll_Should_Return_All()
        {
            MyClass.Reset();
            MyClass.AddOrReplace(1, "a", "A");
            MyClass.AddOrReplace(2, "b", "B");
            MyClass.GetAll().Count.ShouldEqual(2);
        }

        [TestMethod]
        public void AddSameKey_Should_Replace()
        {
            MyClass.Reset();
            MyClass.AddOrReplace(1, "a", "A");
            MyClass.AddOrReplace(2, "b", "B");
            MyClass.AddOrReplace(2, "c", "C");
            var myClasses = MyClass.GetAll();
            foreach (var myClass in myClasses)
            {
                myClass.Log();
            }
            myClasses.Count.ShouldEqual(2);
        }

        [TestMethod]
        public void GetByExistKey_Should_OK()
        {
            MyClass.Reset();
            MyClass.AddOrReplace(1, "a", "A");
            MyClass.AddOrReplace(2, "b", null);
            var a = MyClass.Get(1);
            a.ShouldNotNull();
            a.IntValue.ShouldEqual(1);
            a.StringValue.ShouldEqual("a");
            a.Description.ShouldEqual("A");


            var b = MyClass.Get(2);
            b.ShouldNotNull();
            b.IntValue.ShouldEqual(2);
            b.StringValue.ShouldEqual("b");
            b.Description.ShouldEqual("b");
        }

        [TestMethod]
        public void GetByNotExistKey_Should_Return_Default()
        {
            MyClass.Reset();
            MyClass.AddOrReplace(1, "a", "A");
            MyClass.AddOrReplace(2, "b", null);
            MyClass.Get(3).ShouldNull();
        }

        public class MyClass : CustomizeEnum<MyClass>
        {
        }
    }
}
