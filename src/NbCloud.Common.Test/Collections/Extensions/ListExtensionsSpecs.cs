using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common.Collections.Extensions
{
    [TestClass]
    public class ListExtensionsSpecs
    {
        [TestMethod]
        public void Should_SortByDependencies()
        {
            var a = new DependedObject("A");
            var b = new DependedObject("B");
            var c = new DependedObject("C");
            var d = new DependedObject("D");

            //b,c -> a
            //c -> d
            //d -> b
            b.Dependencies.Add(a);
            c.Dependencies.Add(a);
            c.Dependencies.Add(d);
            d.Dependencies.Add(b);

            ShouldSortedCorrectly(new List<DependedObject> { a, b, c, d });
            ShouldSortedCorrectly(new List<DependedObject> { d, c, b, a });
            ShouldSortedCorrectly(new List<DependedObject> { a, c, d, b });
            ShouldSortedCorrectly(new List<DependedObject> { c, a, d, b });
        }

        private static void ShouldSortedCorrectly(List<DependedObject> dependedObjects)
        {
            var sorted = dependedObjects.SortByDependencies(o => o.Dependencies);
            sorted[0].Name.ShouldEqual("A");
            sorted[1].Name.ShouldEqual("B");
            sorted[2].Name.ShouldEqual("D");
            sorted[3].Name.ShouldEqual("C");
        }

        private class DependedObject
        {
            public string Name { get; private set; }

            public List<DependedObject> Dependencies { get; private set; }

            public DependedObject(string name)
            {
                Name = name;
                Dependencies = new List<DependedObject>();
            }
        }
    }
}
