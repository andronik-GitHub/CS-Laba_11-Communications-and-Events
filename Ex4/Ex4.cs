using System;
using System.Xml.Linq;

class Ex4
{
    static void Main()
    {
        List<Job> jobs = new();
        List<IEmployee> employees = new();

        while (true)
        {
            string[]? action = Console.ReadLine()?.Split(' ');

            if (action != null)
            {
                if (action[0]?.ToLower().Trim() == "end") break;
                else
                {
                    if (action[0]?.ToLower() == "job")
                    {
                        int index = -1;
                        for (int i = 0; i < employees.Count; i++)
                            if (employees[i].Name == action[3]) { index = i; break; };

                        if (index != -1)
                            jobs.Add(new Job(action[1], Convert.ToInt32(action[2]), employees[index]));
                    }
                    else if (action[0]?.ToLower() == "standardemployee")
                        employees.Add(new StandardEmployee(action[1]));
                    else if (action[0]?.ToLower() == "parttimeemployee")
                        employees.Add(new PartTimeEmployee(action[1]));
                    else if (action[0]?.ToLower() == "status")
                        for (int i = 0; i < jobs.Count; i++)
                        {
                            if (jobs[i].active) Console.WriteLine(jobs[i]);
                        }
                    else if (action[0]?.ToLower() == "pass" && action[1]?.ToLower() == "week")
                        for (int i = 0; i < jobs.Count; i++)
                            if (jobs[i].active)
                                jobs[i].Update();
                }
            }
        }


        Console.ReadLine();
    }
}