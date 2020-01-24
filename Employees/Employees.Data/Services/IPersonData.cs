using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public interface IPersonData
    {
        void AddPerson(Person person);
        IEnumerable<Person> GetAll();
        Person GetId(int employeeId);





    }
}
