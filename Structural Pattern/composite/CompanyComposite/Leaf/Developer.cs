using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTree
{
    public class Developer : Employee
    {
        public Developer(long empId, String name, String position, long salary)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public override void showEmployeeDetails()
        {
            Console.WriteLine("ID: {0}. Name: {1}. Position: {2}. Salary: {3}",empId,name,position,salary);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + "ID: {0}. Name: {1}. Position: {2}. Salary: {3}", empId, name, position, salary);
        }
        public override long calculateSalary()
        {
            return this.salary;
        }
    }
}
