using System;

class Job
{
    public bool active;

    string name;
    int hoursOfWorkRequired;

    public string Name { get => name; set => name = value; }
    public int HoursOfWorkRequired { get => hoursOfWorkRequired; set => hoursOfWorkRequired = value; }

    public IEmployee employee { get; set; }


    delegate void Notification();
    event Notification NotificationHours;


    public Job(string name, int hoursOfWorkRequired, IEmployee employee)
    {
        this.name = name;
        this.hoursOfWorkRequired = hoursOfWorkRequired;
        this.employee = employee;

        if (HoursOfWorkRequired > 0) active = true;
        else active = false;

        NotificationHours = delegate () { Console.WriteLine($"Job {Name} done!"); };
    }


    public override string ToString() => $"Job: {Name} Hours Remaining: {HoursOfWorkRequired}";

    public void Update()
    {
        HoursOfWorkRequired -= employee.WorkHoursPerWeek;

        if (HoursOfWorkRequired > 0) active = true;
        else active = false;

        if (HoursOfWorkRequired <= 0) NotificationHours?.Invoke();
    }
}