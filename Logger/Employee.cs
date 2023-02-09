using System;
namespace Logger;

public record class Employee : Person
{
    public Employee(Guid id, FullName fullName) : base(id, fullName)
    { }
}