using System;
namespace GenericsHomework;

public class DuplicateDataInArrayException : Exception
{
    public DuplicateDataInArrayException(string? message) : base(message)
    { }
}
