using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common
{
    public static class TestExtensions
    {
        public static void ShouldNull(this object value)
        {
            Assert.IsNull(value);
        }

        public static void ShouldNotNull(this object value)
        {
            Assert.IsNotNull(value);
        }

        public static void ShouldEqual(this object value, object expectedValue)
        {
            Debug.WriteLine("Should {0} equals {1}?", value, expectedValue);
            Assert.AreEqual(expectedValue, value);
        }

        public static void ShouldTrue(this bool result)
        {
            Assert.IsTrue(result);
        }

        public static void ShouldFalse(this bool result)
        {
            Assert.IsFalse(result);
        }

        public static void Log(this object value)
        {
            if (value == null)
            {
                Debug.WriteLine("null");
            }

            var items = value as IEnumerable;
            if (items != null)
            {
                foreach (var item in items)
                {
                    Debug.WriteLine(item);
                }
                return;
            }

            Debug.WriteLine(value);
        }
    }
}