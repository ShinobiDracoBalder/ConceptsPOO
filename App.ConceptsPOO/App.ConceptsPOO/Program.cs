// See https://aka.ms/new-console-template for more information
using App.ConceptsPOO.Models;

Console.WriteLine("POO Concepts!");
Console.WriteLine("!!!!!!!!!!!!!");

try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(2022, 12, 01));

    Employee employee = new SalaryEmployee()
    {
        Id = 10,
        FirstName = "Sandra",
        LastName = "Morales",
        BirthDate = new Date(1990, 05, 12),
        HiringDate = new Date(2022, 11, 05),
        IsActive = true,
        Salary = 1081545.45M,
    };
    Console.WriteLine(employee);
    Employee employee1 = new CommissionEmployee()
    {
        Id = 11,
        FirstName = "Patricia",
        LastName = "Gutierrez",
        BirthDate = new Date(1990, 05, 12),
        HiringDate = new Date(2022, 11, 05),
        IsActive = true,
        Sales = 32000000M,
        CommissionPercentaje = 0.05F
    };
    Console.WriteLine(employee1);
    Employee employee2 = new BaseCommissionEmployee()
    {
        Id = 11,
        FirstName = "Patricia",
        LastName = "Gutierrez",
        BirthDate = new Date(1990, 05, 12),
        HiringDate = new Date(2022, 11, 05),
        IsActive = true,
        Sales = 32000000M,
        CommissionPercentaje = 0.05F,
        Base = 500000M
    };
    Console.WriteLine(employee2);
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
