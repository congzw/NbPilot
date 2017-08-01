using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common._Specs
{
    [TestClass]
    public class NbObjectSpecs
    {
        [TestMethod]
        public void As_Null_Should_Return_Null()
        {
            INbObject myDemo = null;
            var demoNbObject = myDemo.As<_DemoNbObject>();
            Assert.IsNull(demoNbObject);
        }

        [TestMethod]
        public void As_Instance_Should_Return_Not_Null()
        {
            INbObject myDemo = new _DemoNbObject();
            var demoNbObject = myDemo.As<_DemoNbObject>();
            Assert.IsNotNull(demoNbObject);
        }
    }
    
    #region demo

    internal class _DemoNbObject : INbObject
    {
        public string Name { get; set; }
    }

    internal class _DemoNbObject2
    {
        
    }

    #endregion
}
