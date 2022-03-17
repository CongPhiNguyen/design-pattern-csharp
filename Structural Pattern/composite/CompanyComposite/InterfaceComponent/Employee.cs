using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTree
{
    public abstract class Employee
    {
        protected String name;
        protected long empId;
        protected String position;
        protected long salary;
        public abstract void showEmployeeDetails();
        public abstract void Display(int depth);
        public abstract long calculateSalary();
    }
}
