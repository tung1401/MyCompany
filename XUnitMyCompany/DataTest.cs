using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitMyCompany
{
    public class DataTest
    {

        [Fact]
        [Trait("Priority", "2")] // set piority
        public void TrueTest4()
        {
            var z = "Power BI";
            Assert.True(z.Length > 0); // เป็นจริงเสมอ
        }
        [Fact]
        [Trait("Priority", "1")]
        public void FalseTest4()
        {
            var z = "Power BI";
            Assert.False(z.Length < 0);  // เป็นเท็จเสมอ

        }
    }
}
