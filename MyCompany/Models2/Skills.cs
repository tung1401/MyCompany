using System;
using System.Collections.Generic;

namespace MyCompany.Models2
{
    public partial class Skills
    {
        public Skills()
        {
            Employees = new HashSet<Employees>();
        }

        public int SkillId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
