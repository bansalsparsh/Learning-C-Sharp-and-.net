#pragma warning disable
using System;
class Repository<T> where T : class
{
    public required T Data;
}
class Customer
{
    public required string Name;
}