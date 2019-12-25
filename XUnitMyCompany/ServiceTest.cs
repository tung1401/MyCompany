using MyCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitMyCompany
{
    public class ServiceTest
    {
        [Fact]
        public void CompanyServiceDataTest_Fact()
        {


            CompanyService service = new CompanyService();
            var data = service.GetAll();
            Assert.True(data.Count >= 1);
            Assert.True(data.Any());
        }

        [Theory]
        [InlineData("Aun", 7, true)]
        [InlineData("Dan", 2, true)]
        [InlineData("Bom", 1, true)]
        public void CompanyServiceDataTest_Theory(string name, int skill, bool expected)
        {
            CompanyService service = new CompanyService();
            var data = service.GetAll();

            Assert.True(data.Count >= 1);
            Assert.True(data.Any());

            var testData1 = data.Where(x => x.EmployeeName.ToLower().Contains(name.ToLower())).FirstOrDefault();
            Assert.NotNull(testData1);
            Assert.Equal(expected, testData1 != null);
            Assert.Equal(skill, testData1.SkillId);  
        }
    }
}
