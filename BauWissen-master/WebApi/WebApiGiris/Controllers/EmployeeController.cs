using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiGiris.Models;

namespace WebApiGiris.Controllers
{
    [RoutePrefix("api/employee")]//ortak olanı aldık değişen metodların çağrılması/idli idsiz
    public class EmployeeController : ApiController
    {
        static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){Id=1,Name="PersonA"},
            new Employee(){Id=2,Name="PersonB"},
            new Employee(){Id=3,Name="PersonC"}
        };

        [Route("")]
        public IEnumerable<Employee> Get()
        {
            return Employees;
        }

        //Route constraint/Route kısaltmaları
        //[Route("{id:int:min(1):max(2)}")]
        [Route("{id:int:range(1,10)}",Name ="GetById")]
        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(x => x.Id == id);
        }

        [Route("detail/{id:decimal=1}")]
        public Employee Get(decimal id)
        {
            return Employees.FirstOrDefault(x => x.Id == id);
        }
        [Route("{name:alpha}")]
        public Employee Get(string name)
        {
            return Employees.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }

        [Route("{id}/tasks")]
        public IEnumerable<string> GetEmployeeTask(int id)
        {
            switch (id)
            {
                case 1:
                    return new List<string> { "Task 1-1", "Task 1-2", "Task 1-3" };
                case 2:
                    return new List<string> { "Task 2-1", "Task 2-2", "Task 2-3" };
                case 3:
                    return new List<string> { "Task 3-1", "Task 3-2", "Task 3-3" };


                default: return null;

            }
        }

        [Route("~/api/tasks")]
        public IEnumerable<string> GetTasks()
        {
            return new List<string> { "Task 1-1", "Task 1-2", "Task 1-3", "Task 2-1", "Task 2-2", "Task 2-3","Task 3-1", "Task 3-2", "Task 3-3" };
        }

        //Route name ve route link oluşturma
        [Route("add")]
        public HttpResponseMessage Post(Employee emp)
        {
            emp.Id = Employees.Max(x => x.Id) + 1;
            Employees.Add(emp);

            //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            //response.Headers.Location = new Uri(Request.RequestUri + "/" + emp.Id.ToString());
            //return response;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Url.Link("GetById",new { id=emp.Id}));
            return response;
        }
    }
}
