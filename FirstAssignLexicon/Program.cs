namespace FirstAssignLexicon
{
    class Employee
        {
            public string name;
            public int salary;
                public Employee(string name, int salary)
                {
                    this.name = name;
                    this.salary = salary;
                }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
                {
                Console.WriteLine("To view your employees press 1, to add another employee press 2, to exit please press 3");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 3)
                {
                    break;
                } else if (choice == 2)
                {
                    Console.WriteLine("To add an employee, start with the employee name: ");
                    string employeeName = Console.ReadLine();

                        Console.WriteLine("Add their salary: ");
                    int employeeSalary = int.Parse(Console.ReadLine());


                        Employee employee = new Employee(employeeName, employeeSalary);
                        employees.Add(employee);
                } else if (choice == 1)
                {
                    if (employees.Count != 0)
                    {
                        foreach (Employee item in employees)
                        {
                            Console.WriteLine("Name: " + item.name + " Salary: " + item.salary);
                        }  
                    } else
                    {
                        Console.WriteLine("No employees added yet");
                    }
                }
            }
        }
    }
}
