﻿using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common.Extensions
{
    [TestClass]
    public class CommonExtensionSpecs
    {
        [TestMethod]
        public void ToSplits_Default_Should_Auto_Trim()
        {
            var strings = "a, b，c, d".ToSplits();
            strings[0].ShouldEqual("a");
            strings[1].ShouldEqual("b");
            strings[2].ShouldEqual("c");
            strings[3].ShouldEqual("d");
        }

        [TestMethod]
        public void ToSplits_Not_Trim_Should_OK()
        {
            var strings = "a, b，c, d".ToSplits(null, false);
            strings[0].ShouldEqual("a");
            strings[1].ShouldEqual(" b");
            strings[2].ShouldEqual("c");
            strings[3].ShouldEqual(" d");
        }


        [TestMethod]
        public void GetParamsNameByExtension_Should_OK()
        {
            GetParamsNameByExtension("hello").ShouldEqual("a");
            GetParamsNameByExtension2("hello").ShouldEqual("b");
        }

        [TestMethod]
        public void GetPropertyName_Should_OK()
        {
            var foo = new Foo();
            CommonExtension.NameOf(() => foo.Name).ShouldEqual("Name");
            CommonExtension.NameOf(() => foo.Desc).ShouldEqual("Desc");
        }

        [TestMethod]
        public void GetThisPropertyName_Should_OK()
        {
            this.NameOf(x => x.Hello).ShouldEqual("Hello");
        }

        public string Hello { get; set; }

        public static string GetParamsNameByExtension(string a)
        {
            var nameof = CommonExtension.NameOf(() => a);
            return nameof;
        }

        public static string GetParamsNameByExtension2(string b)
        {
            var nameof = CommonExtension.NameOf(() => b);
            return nameof;
        }

        public class Foo
        {
            public string Name { get; set; }
            public string Desc { get; set; }
        } 
    }
}
