// See https://aka.ms/new-console-template for more information
using PayrollApp;
using System.Collections;

SalariedEmployee irgat0 = new SalariedEmployee(100.0M);
HourlyEmployee irgat1 = new HourlyEmployee(10, 50);
CommissionEmployee irgat2 = new CommissionEmployee(0.5f,500);
SalariedCommissionEmployee irgat3 = new SalariedCommissionEmployee(100, 0.5f, 200);
HourlyEmployee irgat4 = new HourlyEmployee(30.0M, 10);

List<Employee> employees = new List<Employee>() { irgat0, irgat1, irgat2, irgat3, irgat4 };

// For IComparer
/*EmployeeComparer employeeComparer = new EmployeeComparer();
employees.Sort(employeeComparer);*/

//IComparable
employees.Sort();


foreach (Employee employee in employees)
    Console.WriteLine(employee.Payment());

Console.WriteLine("Number of Employee: " + Employee.Count);