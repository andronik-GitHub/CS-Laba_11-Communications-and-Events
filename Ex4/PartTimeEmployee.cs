using System;

class PartTimeEmployee : IEmployee
{
    public string Name { get; set; }
    public int WorkHoursPerWeek { get; set; }

    public PartTimeEmployee(string name)
    {
        Name = name;
        WorkHoursPerWeek = 20;
    }
}