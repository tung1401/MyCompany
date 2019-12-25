using MyCompany.Helper;
using MyCompany.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitMyCompany
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() { 

            int x = 1;
            Assert.NotNull(checkTest(x));

        }
        [Fact]
        public void Test2()
        {
            int y = 0;
            Assert.Null(checkTest(y));

        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(11, checkTest(1));
        }

        [Fact]
        public void TrueTest4()
        {
            var z = "Power BI";
            Assert.True(z.Length > 0);
        }
        [Fact]
        public void FalseTest4()
        {
            var z = "Power BI";
            Assert.False(z.Length > 0);

        }


        [Theory]
        [InlineData(100, 2)] // เงินเดือน 2 เท่า
        [InlineData(50, 1)]
        [InlineData(200, 1)]
        public void HelperHasBonusTest(int work, int expectBonus)
        {
            Assert.Equal(expectBonus, Bonus.HasBonus(work));
        }

        public static IEnumerable<object[]> data =>
        new List<object[]>
        {
             new object[] { true, ".NET" },
             new object[] { false, "JAVA" },
             new object[] { true, "PHP" },
        };

        [Theory]
        [MemberData(nameof(data))]
        public void CanAddTheoryMemberDataProperty(bool bonus, string skill)
        {
            var result = Learn.HasCertificateAndReturnBonus(skill);
            Assert.Equal(bonus, result);
        }

        public int? checkTest(int value)
        {
            if (value == 1) return DateTime.Now.Month;
            return null;
        }

    }
}
