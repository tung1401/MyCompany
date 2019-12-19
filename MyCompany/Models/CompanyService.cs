using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class CompanyService
    {
        private readonly MyCompanyContext _dbContext = new MyCompanyContext();
        public List<Employees> GetAll()
        {
            var query = _dbContext.Employees.ToList();
            return query;
        }

        public List<Employees> GetAllInclude()
        {
            var query = _dbContext.Employees.Include(x => x.Skill).ToList();
            return query;
        }



        public List<Skills> GetAllSkill()
        {
            var query = _dbContext.Skills.ToList();
            return query;
        }
        public void AddSkill(Skills entity)
        {
            _dbContext.Skills.Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
