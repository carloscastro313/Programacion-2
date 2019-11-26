using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExceptionSatelitesIguales()
        {
            try
            {
                bool flag;
                Planeta<Satelite> planeta = new Planeta<Satelite>(20, 20, "Jupiter");
                Satelite s1 = new Satelite(20, 29, "A2");
                Satelite s2 = new Satelite(20, 2, "da");
                Satelite s3 = new Satelite(20, 29, "A2");
                flag =planeta + s1;
                flag = planeta + s2;
                flag = planeta + s3;
            }
            catch (Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(SateliteException));
            }
            
        }
    }
}
