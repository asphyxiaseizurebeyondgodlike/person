class Person
{
    string FullName;
    int age;

    public void move()
    {
        Console.WriteLine($"Cейчас говорит {FullName}") ;
    }

    public void talk()
    {
        Console.WriteLine($"Cейчас говорит {FullName}");
    }
    public Person() 
    { 

    }
     
    public Person(string FullName, int age)
    {
        this.FullName = FullName ;
        this.age = age;
    }

}

class Program
{
    static void Main()
    {
        Person person = new Person("Andew",12);
        Person person1= new Person();

        person.move();
        person1.talk();
    }

}