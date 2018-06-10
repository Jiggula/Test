using System;
using System.Collections.Generic;

namespace Data_drivenSolution
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] arr1 = { "cow", "dog", "cat", "snake", "duck" };
             string[] arr2 = { "moo", "woof", "meow", "hiss", "quack" };
          
            List<Animal> animals = new List<Animal>();
            
             for(var i = 0; i <= 4; i++)
            {
                CreateAnimal(arr2[i], arr1[i]);               
                animals[i].Sing();                
            }
             void CreateAnimal(string sound, string type)
             {
                Animal animal = new Animal
                {
                    Sound = sound,
                    TypeOfAnimal = type
                };
                animals.Add(animal);
             }
    }
    }

    public class Animal
    {
        public string TypeOfAnimal;
        public string Sound;
        public void Sing()
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O,\r\n" +
                              "And on his farm he had a " + TypeOfAnimal + ", E I E I O.\r\n" +
                              $"With a {Sound} {Sound} here and a {Sound} {Sound} there,\r\n" +
                              $"Here a {Sound}, there a {Sound}, ev'rywhere a {Sound} {Sound}.\r\n" +
                              "Old MacDonald had a farm, E I E I O.\r\n");
        }
        
    }
}
