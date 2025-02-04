// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "Joe Zaldana",
    Age = 34,
    Address = new {
        Street = "123 Main St",
        City = "Sao Paulo",
        State = "SP",
        PostalCode = "98001"
    }
};

// Console.WriteLine($"Name: {myobj.Name}, Age: {myobj.Address.Street}");
// Console.WriteLine($"{myobj}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// var myobj2 = myobj with {Name = "Jolene  Jolene"};
// Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");

// TODO: To change a value, use non-destructive mutation and "with" clause


// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");
