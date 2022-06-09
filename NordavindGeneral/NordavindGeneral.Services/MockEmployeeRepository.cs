using NordavindGeneral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordavindGeneral.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>();

            _employeeList.Add(new Employee() {
                Id = 1,
                FullName = "Мерецкий Никита Сергеевич",
                Position = Position.employee,
                Status = "Работник",
                Login = "mernik@nordavind.com",
                Password = "qwerty123",
                Chief = "Антонов Никита Сергеевич"
            }) ;
            _employeeList.Add(new Employee() {
                Id = 2,
                FullName = "Антонов Никита Сергеевич",
                Position = Position.supervisor,
                Status = "Руководитель",
                Login = "shernik@nordavind.com",
                Password = "qwerty1234",
                Chief = "-"
            });
            _employeeList.Add(new Employee() {
                Id = 3,
                FullName = "Иванцова Ольга Дмитриевна",
                Position = Position.HR,
                Status = "Кадровик",
                Login = "shernik@nordavind.com",
                Password = "qwerty1234",
                Chief = "Антонов Никита Сергеевич"
            });
            _employeeList.Add(new Employee() {
                Id = 4,
                FullName = "Петров Василий Иванович",
                Position = Position.admin,
                Status = "Работник",
                Login = "shernik@nordavind.com",
                Password = "qwerty1234",
                Chief = "Антонов Никита Сергеевич"
            });
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
