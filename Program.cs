using LINQexample;
using System.Collections.Generic;
using System.Linq;
using System;


internal class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<person>
{
    new person() { ID = 1, Name = "John", City = "New York", Age = 25 },
    new person() { ID = 2, Name = "Jane", City = "Los Angeles", Age = 30 },
    new person() { ID = 3, Name = "Sam", City = "Chicago", Age = 22 },
    new person() { ID = 4, Name = "Sara", City = "New York", Age = 28 },
    new person() { ID = 5, Name = "Mike", City = "Los Angeles", Age = 35 }
};
        foreach (var person in persons)
        {
            System.Console.WriteLine($"ID: {person.ID}, Name: {person.Name}, City: {person.City}, Age: {person.Age}");
        }
        //Method Syntax
        var query1 = persons.Where(p => p.City == "New York");
        foreach (var person in query1)
        {
            Console.WriteLine($"Filtered - ID: {person.ID}, Name: {person.Name}, City: {person.City}, Age: {person.Age}");
        }
        Console.WriteLine("");
        //Query Syntax
        var query2 = from p in persons
                     where p.Age > 23
                     select p;
        foreach (var person in query2)
        {
            Console.WriteLine($"Filtered - ID: {person.ID}, Name: {person.Name}, City: {person.City}, Age: {person.Age}");
        }
        var ByCityData = persons.GroupBy(p => p.City)
            .Select(p => new
            {
                Count = p.Count(),
                groupkey = p.Key
            });
        foreach (var group in ByCityData)
        {
            Console.WriteLine($"City:{group.groupkey} Count:{group.Count}");
        }
            






    }
}