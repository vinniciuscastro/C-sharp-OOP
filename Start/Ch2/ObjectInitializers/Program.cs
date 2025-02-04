// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog {Name="Fido", Age=3, IsTrained=true};
Cat cat = new Cat {Name="Mr. Meowington", Age=7, IsDeclawed=false};
Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");
Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");

// TODO: Initializers can be used on anonymous types
var pet = new {Name="Charlie", Age=4};
Console.WriteLine($"Pet: {pet.Name}, {pet.Age}");
// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1, 2, 3, 4, 5};
Console.WriteLine($"{numbers.Length}");
Console.WriteLine("");

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner {
    Name = "Joe",
    Pets = new List<Pet> 
    {
        new Dog {Name="Junebug", Age=3, IsTrained=true},
        new Cat {Name="Whiskers", Age=7, IsDeclawed=false},
        new Dog {Name="Junebug", Age=3, IsTrained=true}
    }
};
Console.WriteLine($"Owner: {owner.Name}'s Pets:");
foreach (Pet p in owner.Pets)
{
    Console.WriteLine($"Pet: {p.Name}, {p.Age}");
}