using System;
using System.Xml.Linq;

class StandardEmployee : IEmployee
{
    public string Name { get; set; }
    public int WorkHoursPerWeek { get; set; }

    public StandardEmployee(string name)
    {
        Name = name;
        WorkHoursPerWeek = 40;
    }
}