using System;
using System.Collections.Generic;

namespace practica
{


    class Program
    {
        static void Main()
        {
            //  ==
            //  2.1
            //  ==
            // Задание 1
            /*
            string J = "ab";
            string S = "aabbccd";
            int count = 0;
            for (int i = 0; i < J.Length; ++i)
            {
                for (int j = 0; j < S.Length; ++j)
                {
                    if (J[i] == S[j])
                    {
                        ++count;
                    }
                }
            }
            Console.Write(count);
            */
            // Задание 2
            /*
            int[] candidates = {2, 5, 2, 1, 2};
            int target = 5;
            int sum = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < candidates.Length; ++i)
            {
                result.Clear();
                sum = 0;
                for (int j = 0; j < candidates.Length; ++j)
                {
                    if (i != j)
                    {
                        sum += candidates[j];
                        result.Add(candidates[j]);
                    }
                    if (sum > target)
                    {
                        break;
                    }
                    else if (sum == target)
                    {
                        foreach (var el in result)
                        {
                            Console.Write($"[{el}]");
                        }
                        Console.WriteLine("");
                        break;
                    }
                }
            }
            */        
            // Задание 3
            /*
            int[] nums = {1,2,3,1};
            int cnt = 0;
            bool check = false;
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = 0; j < nums.Length; ++j)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] == nums[j])
                    {
                        ++cnt;
                    }
                }
                if (cnt > 1)
                {
                    check = true;
                    break;
                }
            }
            Console.Write(check);
            */
            //  ==
            //  2.2
            //  ==
            // Задание 1
            /*
            Student one = new Student();
            int[] temp = {5, 2, 3, 4, 1};
            one.ChangeName();
            one.ChangeBirthday();
            one.ChangeNumber();
            one.progress = temp;
            one.PrintStudent();
            */
            // Задание 2
            /*
            Train one = new Train();
            one.name_to = "Moscow";
            one.numberTrain = 101;
            one.time = new DateTime(2022, 01, 01, 15, 30, 00);
            
            Train two = new Train();
            two.name_to = "Vladivostok";
            two.numberTrain = 102;
            two.time = new DateTime(2022, 01, 01, 18, 00, 00);

            Train tree = new Train();
            tree.name_to = "Tomsk";
            tree.numberTrain = 103;
            tree.time = new DateTime(2022, 01, 01, 04, 25, 00);

            int num = 0;
            Console.Write("Введите номер: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == one.numberTrain)
            {
                one.PrintTrain();
            }
            else if (num == two.numberTrain)
            {
                two.PrintTrain();
            }
            else if (num == tree.numberTrain)
            {
                tree.PrintTrain();
            }
            else
            {
                Console.Write("Такого поезда не существует");
            }
            */
            // Задание 3
            /*
            Nums one = new Nums();
            one.ChangeNums();
            one.NumsSum();
            one.CheckNums();
            */
            // Задание 4
            /*
            Counter i = new Counter();
            i.CheckCnt();
            i.SetCnt();
            i.CheckCnt();
            while (i.cnt < 10)
            {
                Console.WriteLine("Cnt");
                i.PlusCnt();
            }
            */
            // Задание 5
            /*
            Democlass demo = new Democlass();
            demo.PrintDemo();
            Democlass demo1 = new Democlass("gr", 621);
            demo1.PrintDemo();
            */
            // ==
            // 2.3
            // ==
            // Задание 1
            /*
            Worker one = new Worker("Kostyn", "Skeletov", 1000, 30);
            one.GetSalary();
            */
            // Задание 2
            /*
            Worker2 one = new Worker2("MC", "Denton", 2500, 10);
            Console.Write($"Зп: {one.GetSalary()}");
            */
            // Задание 3
            /*
            Calculation one = new Calculation();
            one.SetCalculationLine();
            Console.WriteLine(one.GetCalculationLine());
            Console.WriteLine(one.GetLastSymbol());
            one.SetLastSymbolCalculationLine('f');
            Console.WriteLine(one.GetCalculationLine());
            one.DeleteLastSymbol();
            Console.WriteLine(one.GetCalculationLine());
            */
            // == 
            // 2.4
            // ==
            // Римские цифры
            /*
            string str = "MCMXCIV";
            int sum = 0;
            str = "!" + str + "=";
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == 'I')
                {
                    if (str[i + 1] == 'V')
                    {
                        sum += 4;
                    }
                    else if(str[i] == 'X')
                    {
                        sum += 9;
                    }
                    else
                    {
                        ++sum;
                    }
                }
                else if (str[i] == 'V' && str[i - 1] != 'I')
                {
                    sum += 5;
                }
                else if (str[i] == 'X')
                {
                    if (str[i + 1] == 'L')
                    {
                        sum += 40;
                    }
                    else if (str[i + 1] == 'C')
                    {
                        sum += 90;
                    }
                    else if(str[i - 1] != 'I')
                    {
                        sum += 10;
                    }
                }
                else if (str[i] == 'L' && str[i - 1] != 'X')
                {
                    sum += 50;
                }
                else if (str[i] == 'C')
                {
                    if (str[i + 1] == 'D')
                    {
                        sum += 400;
                    }
                    else if (str[i + 1] == 'M')
                    {
                        sum += 900;
                    }
                    else if(str[i - 1] != 'X')
                    {
                        sum += 100;
                    }
                }
                else if (str[i] == 'D' && str[i - 1] != 'C')
                {
                    sum += 500;
                }
                else if (str[i] == 'M' && str[i - 1] != 'C')
                {
                    sum += 1000;
                }
            
                if (str[i] == '=')
                {
                    break;
                }

            }
            Console.WriteLine(sum);
            */
            // 
        }
    }
}
