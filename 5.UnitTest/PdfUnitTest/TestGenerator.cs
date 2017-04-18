using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BCG.CD.Dynamic.DAL.SharedModels;

namespace BCG.CD.Dynamic.UnitTest.PdfUnitTest
{
    [TestFixture]
    public class TestGenerator
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            BlockItem item = new BlockItem();
            Assert.IsInstanceOf<BlockItem>(item);
        }
    }
}
