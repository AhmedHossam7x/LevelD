using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.COVARIANCE
{
    internal class COVARIANCE
    {
    }
    public class Fruit
    {
    }
    public class Apple : Fruit
    {
        public Apple CreatedApple()
        {
            Console.WriteLine("The new Apple is created");
            return new Apple();
        }
    }
    public class Orange : Fruit
    {
        public Orange CreatedOrange()
        {
            Console.WriteLine("The new Orange is created");
            return new Orange();
        }
    }
    public class Banana : Fruit
    {
        public Banana CreatedBanana()
        {
            Console.WriteLine("The new Banana is created");
            return new Banana();
        }
    }

    public class AppleJuiceFactory
    {
        public void CreateAppleJuice(Apple apple)
        {
            Console.WriteLine("Create apple juice");
        }
    }
    public class FruitJuiceFactory
    {
        public void CreateFruitJuice(Fruit fruit)
        {
            Console.WriteLine("Create fruit juice");
        }
    }
}
