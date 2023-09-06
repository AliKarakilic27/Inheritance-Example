/* EXAMPLE 1

// Abstract class  Example
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Dog Sleeping:ZZZZ");
    }
}

// Derived class (inherit from Animal)
class Dog : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("Dog Barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog(); // Create a Pig object
        myDog.animalSound();  // Call the abstract method
        myDog.sleep();  // Call the regular method
    }
}

*/





/*  EXAMPLE 2

// Interface Example
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Canary : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The Canary Sings: Cik Cik Cik");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Canary myCanary = new Canary();  // Create a Pig object
        myCanary.animalSound();
    }
}

*/


/* EXAMPLE 3

// Inheritance Example
class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  
    public void honk()              
    {
        Console.WriteLine("Car Horn Daaad, Daaad! It Makes a Sound");
    }
}

class Car : Vehicle  
{
    public string modelName = "Mustang";  
}

class Program
{
    static void Main(string[] args)
    {
      
        Car myCar = new Car();

        
        myCar.honk();

       
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

*/
