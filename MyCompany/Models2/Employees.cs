using System;
using System.Collections.Generic;

namespace MyCompany.Models2
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public int? SkillId { get; set; }
        public int? YearsExperience { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
