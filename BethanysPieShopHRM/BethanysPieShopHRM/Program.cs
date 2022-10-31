﻿using System;
using System.Text;
using BethanysPieShopHRM.HR;


Console.WriteLine("Creating an employee");
Console.WriteLine("____________________\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Console.WriteLine("Creating an employee");
Console.WriteLine("____________________\n");

Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), null, EmployeeType.Research);


List<Employee> employees = new List<Employee>();
for (int i = 0; i < 10000000; i++)
{
    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), null, EmployeeType.StoreManager);
    employees.Add(randomEmployee);
}

employees.Clear();
employees = null;

Console.ReadLine();







