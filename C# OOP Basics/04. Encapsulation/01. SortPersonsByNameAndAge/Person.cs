﻿public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName => this.firstName;
    public string LastName => this.lastName;
    public int Age => this.age;
   

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
    }
}