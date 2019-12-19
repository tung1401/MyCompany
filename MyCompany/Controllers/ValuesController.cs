using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Models;

namespace MyCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        CompanyService service = new CompanyService();
        // GET api/values
        [HttpGet]
        public ActionResult<List<Employees>> Get()
        {
            return service.GetAllInclude().OrderBy(x => x.EmployeeName).ToList();
           // return service.GetAllInclude();
        }

        // GET api/values/5
        [HttpGet("Employee/{id}")]
        public ActionResult<Employees> Get(int id)
        {
            return service.GetAll().Where(x=>x.EmployeeId == id).FirstOrDefault();
        }

        [HttpGet("Skill")]
        public ActionResult<List<Skills>> GetAllSkill()
        {

            return service.GetAllSkill();
        }

        // POST api/values
        [HttpPost]
        public ActionResult<List<Skills>> Post([FromBody] SkillDto dto)
        {

            service.AddSkill(new Skills
            {
                Title = dto.Title
            });

            return service.GetAllSkill();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class SkillDto
    {
        public string Title { get; set; }
    }
}
