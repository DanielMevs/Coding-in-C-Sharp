﻿//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//    ["USA"] = "USD",
//    ["India"] = "INR",
//    ["Spain"] = "EUR",
//};

//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//    { "USA", "USD" },
//    { "India", "INR" },
//    { "Spain", "EUR" },
//};

var countryToCurrencyMapping = new Dictionary<string, string>();
countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("Spain", "EUR");
countryToCurrencyMapping.Add("Italy", "EUR");

//Console.WriteLine("Currency in Spain is " +
//    countryToCurrencyMapping["Spain"]);

//if (countryToCurrencyMapping.ContainsKey("Italy"))
//{
//    Console.WriteLine("Currency in Italy is " +
//        countryToCurrencyMapping["Italy"]);
//}

countryToCurrencyMapping["Poland"] = "PLN";

//foreach (var country in countryToCurrencyMapping)
//{
//    Console.WriteLine(
//        $"Country: {country.Key}, "+
//        $"currency: {country.Value}");
//}

var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Mechanics", 21000),
    new Employee("Gustavo Sanchez", "Mechanics", 20000),
};

var result = CalculateAverageSalaryPerDepartment(employees);



Console.ReadKey();
Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(
    IEnumerable<Employee> employees)
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();

    foreach(var employee in employees)
    {
        if (!employeesPerDepartments.ContainsKey(employee.Department))
        {
            employeesPerDepartments[employee.Department] = new List<Employee>();
        }
        employeesPerDepartments[employee.Department].Add(employee);
    }

    var result = new Dictionary<string, decimal>();

    foreach(var employeesPerDept in employeesPerDepartments)
    {
        decimal sumOfSalaries = 0;

        foreach(var employee in employeesPerDept.Value)
        {
            sumOfSalaries += employee.MonthlySalary;
        }

        var average = sumOfSalaries / employeesPerDept.Value.Count;

        result[employeesPerDept.Key] = average;
    }

    return result;
}
public class Employee
{
    public Employee(string name, string department, decimal monthlySalary)
    {
        Name = name;
        Department = department;
        MonthlySalary = monthlySalary;
    }

    public string Name { get; init; }
    public string Department { get; init; }
    public decimal MonthlySalary { get; init; }
}