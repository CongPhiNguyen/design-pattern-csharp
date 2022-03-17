namespace CompositeTree
{
    class MainApp
    {
        public static void Main()
        {
            Developer dev1 = new Developer(100, "Nguyen Cong Phi", "Software Developer", 20000000);
            Developer dev2 = new Developer(101, "Luong Thien Phuoc", "Web Developer", 20000000);

            CompanyDirectory devDirectory = new CompanyDirectory("Developer directory");
            devDirectory.addEmployee(dev1);
            devDirectory.addEmployee(dev2);

            Manager man1 = new Manager(200, "Pham Nguyen Minh Thang", "SEO Manager", 21000000);
            Manager man2 = new Manager(201, "Bui Nhu Phuoc", "Operation Manager", 22000000);
            Manager man3 = new Manager(203, "Nguyen Tan Thanh", "Project Manager",21000000);

            CompanyDirectory manDirectory = new CompanyDirectory("Manager directory");
            manDirectory.addEmployee(man1);
            manDirectory.addEmployee(man2);
            manDirectory.addEmployee(man3);

            CompanyDirectory directory = new CompanyDirectory("Company directory");
            directory.addEmployee(devDirectory);
            directory.addEmployee(manDirectory);

            directory.Display(1);
            Console.WriteLine("\nTotal Salary: {0}", directory.calculateSalary());
            Console.WriteLine("Total Dev Salary: {0}", devDirectory.calculateSalary());
            Console.WriteLine("Total Manager Salary: {0}", manDirectory.calculateSalary());
        }
    }
}
