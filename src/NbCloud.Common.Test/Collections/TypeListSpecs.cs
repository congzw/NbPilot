using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common.Collections
{
    [TestClass]
    public class TypeListSpecs
    {
        [TestMethod]
        public void Should_Only_Add_True_Types()
        {
            var list = new TypeList<IMyInterface>();
            list.Add<MyClass1>();
            list.Add(typeof(MyClass2));
            Action action = () => list.Add(typeof(MyClass3));
            action.ShouldThrows<ArgumentException>();
            AssertHelper.ShouldThrows<ArgumentException>(() => list.Add(typeof(MyClass3)));
        }

        public interface IMyInterface
        {

        }

        public class MyClass1 : IMyInterface
        {

        }

        public class MyClass2 : IMyInterface
        {

        }

        public class MyClass3
        {

        }
    }
}
