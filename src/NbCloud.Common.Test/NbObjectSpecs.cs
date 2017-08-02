using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NbCloud.Common
{
    [TestClass]
    public class NbObjectSpecs
    {
        [TestMethod]
        public void As_Null_Should_Return_Null()
        {
            INbObject myDemo = null;
            myDemo.As<_DemoNbObject>().ShouldNull();
        }

        [TestMethod]
        public void As_Instance_Should_Return_Not_Null()
        {
            INbObject myDemo = new _DemoNbObject();
            myDemo.As<_DemoNbObject>().ShouldNotNull();
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
