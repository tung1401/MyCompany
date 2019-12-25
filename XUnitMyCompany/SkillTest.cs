using MyCompany.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitMyCompany
{
    public class SkillTest
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            
            List<Skills> skillList = new List<Skills>();
            skillList.Add(new Skills { Title = "Java" });

            //add in method
            Skills skill = new Skills { Title = "React" };
            skillList = Add(skillList, skill);

            Assert.True(skillList.Count == 1);
            Assert.Contains<Skills>(skill, skillList);
        }

        public List<Skills> Add(List<Skills> skillList, Skills skill)
        {
            if (string.IsNullOrWhiteSpace(skill.Title))
            {
                throw new ArgumentException("You passed in an invalid parameter", "Title");
            }

            skillList.Add(skill);
            return skillList;
        }



        //Expect Exception by Property
        [Theory]
        [InlineData("Tim", "", "PhoneNumber")]
        [InlineData("", "Corey", "EmployeeName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string phoneNumber, string property)
        {
            Employees employee = new Employees { EmployeeName = firstName , PhoneNumber = phoneNumber};
            List<Employees> empList = new List<Employees>();

            Assert.Throws<ArgumentException>(property, () => AddEmp(empList, employee));
        }

        public List<Employees> AddEmp(List<Employees> empList, Employees emp)
        {
            if (string.IsNullOrWhiteSpace(emp.EmployeeName))
            {
                throw new ArgumentException("You passed in an invalid parameter", "EmployeeName");
            }

            if (string.IsNullOrWhiteSpace(emp.PhoneNumber))
            {
                throw new ArgumentException("You passed in an invalid parameter", "PhoneNumber");
            }

            empList.Add(emp);
            return empList;
        }

    }
}
