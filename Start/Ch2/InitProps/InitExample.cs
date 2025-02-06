// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// init-only modifier
using System.Diagnostics.CodeAnalysis;

public class Employee {
    private readonly int _id;

    public Employee() {}
    [SetsRequiredMembers]
    public Employee(string fname, string lname, int id, string dept) {
        FirstName = fname;
        LastName = lname;
        ID = id;
        Department = dept;
    }

    // The init keyword means that a value is assigned only during construction
    public int ID {
        get => _id;
        init => _id = value;
    }
    public string? Department {
        get; set;
    }
    public string? FirstName {
        get; set;
    }
    public string? LastName {
        get; set;
    }

    

    public override string ToString() => $"{FirstName} {LastName}, ID:{ID} in {Department}";
}
