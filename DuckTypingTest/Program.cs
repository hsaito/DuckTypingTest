using System;

namespace DuckTypingTest
{
    internal class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quaaaaaack!");
        }

        public void Feathers()
        {
            Console.WriteLine("The duck has white and gray feathers.");
        }
    }

    internal class Person
    {
        public void Quack()
        {
            Console.WriteLine("The person imitates a duck.");
        }

        public void Feathers()
        {
            Console.WriteLine("The person takes a feather from the ground and shows it.");
        }
    }

    internal static class Program
    {
        private static void InTheForest(dynamic obj)
        {
            obj.Quack();
            obj.Feathers();
        }

        private static void Game()
        {
            var donald = new Duck();
            var john = new Person();
            InTheForest(donald);
            InTheForest(john);
        }

        private static void Main()
        {
            Game();
        }
    }
}