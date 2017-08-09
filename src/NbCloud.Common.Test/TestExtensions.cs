using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace NbCloud.Common
{
    public static class TestExtensions
    {
        public static void ShouldThrows<T>(this Action action) where T : Exception
        {
            AssertHelper.ShouldThrows<T>(action);
        }

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
            string message = string.Format("Should {0} equals {1}?", value, expectedValue);
            Assert.AreEqual(expectedValue, value, message.WithKOPrefix());
            AssertHelper.WriteLineOK(message);
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

        public static void LogJson(this object value)
        {
            if (value == null)
            {
                Debug.WriteLine("null");
            }

            var serializeObject = JsonConvert.SerializeObject(value);
            Debug.WriteLine(serializeObject);
        }


        public static string WithOKPrefix(this string value)
        {
            return AssertHelper.PrefixOK(value);
        }
        public static string WithKOPrefix(this string value)
        {
            return AssertHelper.PrefixKO(value);
        }
    }

    public class AssertHelper
    {
        public static readonly string OK = "✔";
        public static readonly string KO = "✘";

        public static void ShouldThrows<T>(Action action) where T : Exception
        {
            T expectedEx = null;
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    var baseException = ex.GetBaseException();
                    WriteLineOK("抛出了异常:" + baseException.Message);
                    expectedEx = baseException as T;
                }
                else
                {
                    WriteLineOK("抛出了异常:" + ex.Message);
                    expectedEx = ex as T;
                }
            }
            Assert.IsNotNull(expectedEx, PrefixKO("没有发现应该抛出的异常: " + typeof(T).Name));
        }
        public static string PrefixOK(string value)
        {
            return OK + " " + value;
        }
        public static string PrefixKO(string value)
        {
            return KO + " " + value;
        }
        public static void WriteLineOK(string message)
        {
            Debug.WriteLine(PrefixOK(message));
        }
        public static void WriteLineKO(string message)
        {
            Debug.WriteLine(PrefixKO(message));
        }
    }
}