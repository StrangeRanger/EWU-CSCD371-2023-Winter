using System;
namespace Logger;

public record class Student : Person
{
    public Student(Guid id, FullName fullName) : base(id, fullName)
    {
    }
}
