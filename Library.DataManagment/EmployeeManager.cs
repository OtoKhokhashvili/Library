using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataManagment
{
    class EmployeeManager
    {
        private List<Employee> _employeeList;

        private int _generatedID = 0;
        public EmployeeManager()
        {
            _employeeList = new List<Employee>();
        }

        public int Add(Employee employee)
        {
            _generatedID++;
            employee.Id = _generatedID;
            _employeeList.Add(employee);
            return employee.Id;
        }

        public void Delete(int Id)
        {
            int index = GetIndexById(Id);
            if (index == -1)
            {
                throw new Exception("Employee Id not found");
            }
            _employeeList.RemoveAt(index);
        }

        public void Edit(Employee employee)
        {
            int index = GetIndexById(employee.Id);
            if (index == -1)
            {
                throw new Exception("Employee Id not found");
            }
            _employeeList[index] = employee;
        }

        private int GetIndexById(int Id)
        {
            for (int i = 0; i < _employeeList.Count; i++)
            {
                if (_employeeList[i].Id == Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
