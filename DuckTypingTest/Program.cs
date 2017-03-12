using static System.Console;

class Duck
{
    public void Quack() => WriteLine("Quaaaaaack!");
    public void Feathers() => WriteLine("The duck has white and gray feathers.");
}

class Person
{
    public void Quack() => WriteLine("The person imitates a duck.");
    public void Feathers() => WriteLine("The person takes a feather from the ground and shows it.");
}

class Program
{
    static void InTheForest(dynamic obj)
    {
        obj.Quack();
        obj.Feathers();
    }

    static void Game()
    {
        Duck donald = new Duck();
        Person john = new Person();
        InTheForest(donald);
        InTheForest(john);
    }

    static void Main()
    {
        Game();
    }
}