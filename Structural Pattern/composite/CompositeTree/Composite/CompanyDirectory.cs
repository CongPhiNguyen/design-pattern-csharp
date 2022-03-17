using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTree
{
    class CompanyDirectory : Employee
    {
        private List<Employee> employeeList = new List<Employee>();
        private String name;

        public CompanyDirectory(string name)
        {
            this.name = name;
        } 
        public override void showEmployeeDetails()
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employee employee = employeeList[i];
                employee.showEmployeeDetails();
            }
        }

        public void addEmployee(Employee emp)
        {
            employeeList.Add(emp);
        }

        public void removeEmployee(Employee emp)
        {
            employeeList.Remove(emp);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.name);
            // Recursively display child nodes
            foreach (Employee component in employeeList)
            {
                component.Display(depth + 2);
            }
        }

        public override long calculateSalary()
        {
            long res = 0;
            foreach (Employee component in employeeList)
            {
                res += component.calculateSalary();
            }
            return res;
        }
    }
}
