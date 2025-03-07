// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    
    public Employee() {}
    
    public required int ID {get; set;}
    public required string? Department {get; set;}
    public required string? FullName {get; set;}

    public void AdjustPay(decimal percent) {}
       // YOUR CODE GOES HERE

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public class HourlyEmployee : Employee {
    public required decimal PayRate {get; set;}
    public void AdjustPay(decimal percent) {
        PayRate += PayRate * percent;
    }
       // YOUR CODE GOES HERE
}

public class SalariedEmployee : Employee {
    public required decimal Salary {get; set;}
    public void AdjustPay(decimal percent) {
        Salary += Salary * percent;
    }
       // YOUR CODE GOES HERE
}

// DEFINE OTHER CLASSES HERE
