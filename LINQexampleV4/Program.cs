using LINQexampleV4;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

List<Employee> employeeList= Data.GetEmployees();
List<Department> departmentList = Data.GetDepartments();

////SequenceEqual, Equal Operation
//var intList1 = new List<int> { 1,2,3,4,5,6};
//var intList2 = new List<int> { 1,2,3,4,5,6};
//var boolSequenceEqual= intList1.SequenceEqual(intList2);
//Console.WriteLine(boolSequenceEqual);
//var employeeListCompare = Data.GetEmployees();
//bool boolSE = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());
//Console.WriteLine(boolSE);

////Concat Opearation
//List<int> intList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
//List<int> intList2 = new List<int> { 10, 12, 133, 54, 45, 16 };
//IEnumerable<int> intConcat = intList1.Concat(intList2).Order();
//foreach (int i in intConcat)
//    Console.WriteLine(i);
//List<Employee> employeeList2 = new List<Employee> { new Employee { Id = 5, FirstName = "Tony", LastName = "Stark" }, new Employee { Id = 6, FirstName = "Debbie", LastName = "Townsend" } };
//IEnumerable<Employee> results= employeeList.Concat(employeeList2);
//foreach (var employee in results)
//    Console.WriteLine($"{employee.Id, -5} {employee.FirstName, -20} {employee.LastName,20}");


////Aggregate Operators
//decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totalAnnualSalary, e) =>
//{
//    var bonus = (e.IsManager) ? 0.04m : 0.02m;
//    totalAnnualSalary = e.AnnualSalary + bonus*e.AnnualSalary;
//    return totalAnnualSalary;
//});
//Console.WriteLine(totalAnnualSalary);
//string data = employeeList.Aggregate<Employee, string, string>("Employee Annual Salaries(include bonus):",
//    (s, e) =>
//    {
//        var bonus = (e.IsManager) ? 0.04m : 0.02m;
//        s += $"{e.FirstName} {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}, ";
//        return s;
//    }, s => s.Substring(0, s.Length - 2));
//Console.WriteLine(data);
//decimal avarage = employeeList.Where(e=> e.DepartmentId==2).Average(e => e.AnnualSalary);
//Console.WriteLine(avarage);
//int countEmployees=employeeList.Count;
//Console.WriteLine(countEmployees);
//int countEmployees=employeeList.Count(e=>e.DepartmentId==3);
//Console.WriteLine(countEmployees);
//decimal result = employeeList.Sum(e=>e.AnnualSalary);
//Console.WriteLine(result);
//decimal maxRes = employeeList.Max(e => e.AnnualSalary);
//Console.WriteLine(maxRes);
//decimal minRes = employeeList.Min(e => e.AnnualSalary);
//Console.WriteLine(minRes);

////Generation Operation
//List<int> intList = new List<int>();
//var newList = intList.DefaultIfEmpty(99999);
//Console.WriteLine(newList.ElementAt(0));
//List<Employee> employees= new List<Employee>();
//var newList = employees.DefaultIfEmpty(new Employee { Id = 0 });
//var res= newList.ElementAt(0);
//if (res.Id == 0)
//    Console.WriteLine("List is empty");
//List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();
//emptyEmployeeList.Add(new Employee { Id = 7, FirstName = "Dan", LastName = "Brown" });
//foreach (var item in emptyEmployeeList)
//    Console.WriteLine($"{item.FirstName} {item.LastName}");
//var intCollection= Enumerable.Range(25,20);
//foreach (var item in intCollection)
//    Console.WriteLine(item);
//var strCollection = Enumerable.Repeat<string>("Test", 10);
//foreach (var item in strCollection)
//    Console.WriteLine(item);

////Set Operators
//List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
//var results = list.Distinct();
//foreach (var item in results)
//    Console.WriteLine(item);
//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
//IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6 };
//var results = collection1.Except(collection2);
//var results = collection2.Except(collection1);
//foreach (var item in results)
//    Console.WriteLine(item);
//List<Employee> employeeList2 = new List<Employee>();
//employeeList2.Add(new Employee
//{
//    Id = 1,
//    FirstName = "Bob",
//    LastName = "Jones",
//    AnnualSalary = 60000.3m,
//    IsManager = true,
//    DepartmentId = 2
//}
//);
//employeeList2.Add(new Employee
//{
//    Id = 3,
//    FirstName = "Douglas",
//    LastName = "Roberts",
//    AnnualSalary = 40000.2m,
//    IsManager = false,
//    DepartmentId = 1
//}
//);
//employeeList2.Add(new Employee
//{
//    Id = 5,
//    FirstName = "Craig",
//    LastName = "Laurence",
//    AnnualSalary = 20000.2m,
//    IsManager = false,
//    DepartmentId = 1
//}
//);
//employeeList2.Add(new Employee
//{
//    Id = 6,
//    FirstName = "Elizabeth",
//    LastName = "Tate",
//    AnnualSalary = 85000,
//    IsManager = true,
//    DepartmentId = 1
//}
//);
//var res=employeeList.Except(employeeList2,new EmployeeComparer());
//foreach (var item in res)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-20} {item.LastName,20}");
//var res = employeeList.Intersect(employeeList2,new EmployeeComparer());
//foreach (var item in res)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-20} {item.LastName,20}");
//var res = employeeList.Union(employeeList2, new EmployeeComparer());
//foreach (var item in res)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-20} {item.LastName,20}");

////Partitioning Operators
//var results = employeeList.Skip(2);
//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-20} {item.LastName,20}");
employeeList.Add(new Employee { Id = 5, FirstName = "Same", LastName = "Davis", AnnualSalary = 1000000 });
var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
foreach (var item in results)
    Console.WriteLine($"{item.Id,-5} {item.FirstName,-20} {item.LastName,20} {item.AnnualSalary,-10}");



Console.ReadKey();
public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
    {
        if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
        {
            return true;
        }
        return false;
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        return obj.Id.GetHashCode();
    }
}