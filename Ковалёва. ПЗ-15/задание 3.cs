using System;

class Person
{
    string name;
    int age;

    public Person()
    {
    }
    public Person(string name) : this(name, 18)
    {
    }
    public Person(string name, int age)
    {
        this.name = namе;
        this.age = age;
    }
}
class Employee : Person
{
    string company;

    public Employee()
    {
    }
    public Employee(string name, int age, string company) :
 base(namе, age)
    {
        this.company = company;
    }
    public Employee((string name, string company) : base(namе)
    {
        this.company = company;
    }

}
