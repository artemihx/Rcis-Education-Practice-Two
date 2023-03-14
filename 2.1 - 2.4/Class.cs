using System;

class Democlass
{
    public string str;
    public int num;
    
    public void PrintDemo()
    {
        Console.Write($"{str} {num}\n");
    }

    public Democlass()
    {
        Console.Write("Создание объекта класса\n");
        str = "null";
        num = 0;
    }
    public Democlass(string n, int a)
    {
        str = n;
        num = a;
    }
    
    ~Democlass()
    {
        Console.Write($"Удаление объекта класса");
    }
}

class Counter
{
    public int cnt = 0;
    public void SetCnt()
    {
        cnt = Convert.ToInt32(Console.ReadLine());
    }
    public void CheckCnt()
    {
        Console.Write($"Счётчик: {cnt}\n");
    }
    public void PlusCnt()
    {
        ++cnt;
    }
    public void MinCnt()
    {
        --cnt;
    }
}

class Nums
{
    int a;
    int b;
    public void PrintNums()
    {
        Console.Write($"{a}, {b}");
    }
    public void ChangeNums()
    {
        Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public void NumsSum()
    {
        Console.Write($"{a} + {b} = {a + b}\n");
    }
    public void CheckNums()
    {
        if (a > b)
        {
            Console.Write($"{a} > {b}\n");
        }
        else if (a < b)
        {
            Console.Write($"{a} < {b}\n");
        }
        else
        {
            Console.Write($"{a} = {b}\n");
        }
    }
}

class Train
{
    public string name_to = "unknown";
    public int numberTrain = 0;
    public DateTime time;
    public void PrintTrain()
    {
        Console.Write($"==\nПоезд номер: {numberTrain}\nНаправление: {name_to}\nВремя отправления: {time.ToShortTimeString()}\n==");
    }

}

class Student
    {
        public string name = "Undefined";
        public DateTime birthday = new DateTime();
        public int number = 0;
        public int[] progress = new int[5];

        public void ChangeName()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
        }
        public void ChangeBirthday()
        {
            string temp = "";
            Console.Write("Введите дату: ");
            temp = Console.ReadLine();
            birthday = DateTime.Parse(temp);
        }
        public void ChangeNumber()
        {
            Console.Write("Введите номер группы: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintStudent()
        {
            Console.Write($"Имя - {name}\nДата рождения - {birthday}\nНомер группы - {number}\n");
            Console.Write("Успеваемость: ");
            foreach (int item in progress)
            {
                Console.Write($"{item}, ");
            }
        }
    }