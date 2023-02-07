using System;
class Person
{
    string FullName;
    byte age;

    public void move()
    {
        Console.WriteLine($"Cейчас говорит {FullName}");
    }

    public void talk()
    {
        Console.WriteLine($"Cейчас говорит {FullName}");
    }

    public Person() { }

    public Person(string FullName, byte age)
    {
        this.FullName = FullName;
        this.age = age;
    }

}

class Program
{
    static void Main()
    {
        Person person = new Person("Вася", 17);
        Person person1 = new Person();

        person1.talk();
        person.move();

    }

}
