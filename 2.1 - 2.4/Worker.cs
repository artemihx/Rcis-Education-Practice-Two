using System;

class Worker
{
    string name;
    string surname;
    int rate;
    int days;
    public Worker(string n, string s, int r, int d)
    {
        name = n;
        surname = s;
        rate = r;
        days = d;
    }

    public void GetSalary()
    {
        Console.Write($"Зарплата {name} {surname} : {rate * days}");
    }
}

class Worker2
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
    }
    private string surname;
    public string Surname
    {
        get
        {
            return surname;
        }
    }
    private int rate;
    public int Rate
    {
        get
        {
            return rate;
        }
    }
    private int days;
    public int Days
    {
        get
        {
            return days;
        }
    }
    public Worker2(string n, string s, int r, int d)
    {
        name = n;
        surname = s;
        rate = r;
        days = d;
    }

    public int GetSalary()
    {
        return rate * days;
    }
}