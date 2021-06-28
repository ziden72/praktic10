using System;

namespace praktic10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Выберите действие: 0 - конвертация из римских в арабские, 1 - конвертация из арабских в римские: ");
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    Console.WriteLine("Введите римское число: ");
                    string a = Console.ReadLine().ToUpper();
                    int b = 0;
                    string[] roman = { "CM", "CD", "XC", "XL", "IX", "IV" };
                    string[] romanNormal = { "M", "D", "C", "L", "X", "V" };
                    int[] arab = { 900, 400, 90, 40, 9, 4 };
                    int[] arabNormal = { 1000, 500, 100, 50, 10, 5 };
                    for (int i = 0; i < roman.Length; i++)
                    {
                        if (a.Contains(roman[i]))
                        {
                            a = a.Replace(roman[i], "");
                            b += arab[i];
                        }
                    }
                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < romanNormal.Length; j++)
                        {
                            if (a[i].ToString() == romanNormal[j])
                            {
                                b += arabNormal[j];
                            }
                        }
                    }
                    Console.WriteLine(b);
                    break;
                case 1:
                    Console.WriteLine("Введите число: ");
                    int aAr = Int32.Parse(Console.ReadLine());
                    string bAr = "";
                    int M = 0, CM = 0, CD = 0, XC = 0, XL = 0, IX = 0, IV = 0, D = 0, C = 0, L = 0, X = 0, V = 0, I = 0;
                    if (aAr > 1000)
                    {
                        M = aAr / 1000;
                        aAr %= 1000;
                        for (int i = 0; i < M; i++)
                        {
                            bAr += "M";
                        }
                    }
                    if (aAr >= 900)
                    {
                        CM += 1;
                        aAr %= 900;
                        bAr += "CM";
                    }
                    if (aAr >= 500)
                    {
                        D += 1;
                        aAr %= 500;
                        bAr += "D";
                    }
                    if (aAr >= 400)
                    {
                        CD += 1;
                        aAr %= 400;
                        bAr += "CD";
                    }
                    if (aAr >= 100)
                    {
                        C = aAr / 100;
                        aAr %= 100;
                        for (int i = 0; i < C; i++)
                        {
                            bAr += "C";
                        }
                    }
                    if (aAr >= 90)
                    {
                        XC += 1;
                        aAr %= 90;
                        bAr += "XC";
                    }
                    if (aAr >= 50)
                    {
                        L += 1;
                        aAr %= 50;
                        bAr += "L";
                    }
                    if (aAr >= 40)
                    {
                        XL += 1;
                        aAr %= 40;
                        bAr += "XL";
                    }
                    if (aAr > 10)
                    {
                        X = aAr / 10;
                        aAr %= 10;
                        for (int i = 0; i < X; i++)
                        {
                            bAr += "X";
                        }
                    }
                    if (aAr == 9)
                    {
                        IX = 9;
                        bAr += "IX";
                        aAr = 0;
                    }
                    if (aAr >= 5)
                    {
                        V = 1;
                        aAr %= 5;
                        bAr += "V";
                    }
                    if (aAr == 4)
                    {
                        IV = 1;
                        bAr += "IV";
                        aAr = 0;
                    }
                    if (aAr < 4 && aAr > 0)
                    {
                        I = aAr;
                        for (int i = 0; i < I; i++)
                        {
                            bAr += "I";
                        }
                    }
                    Console.WriteLine(bAr);
                    break;
            }
            //2
            Console.WriteLine("2) Введите число");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = y;
            int rev = 0;
            int dig = 0;
            while (y > 0)
            {
                dig = y % 10;
                rev = rev * 10 + dig;
                y = y / 10;
            }
            if (n == rev)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
            //2 часть
            int[,] h = new int[10, 10];
            int[] h1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random k = new Random();
                    int f = k.Next(0, 10);
                    h[i, j] = f;
                }
            }
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(String.Format("{0,3}", h[i, j]));
                Console.WriteLine();
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    h1[j] = h[j, i];
                }
                Array.Sort(h1);
                for (int u = 0; u < 9; u++)
                {
                    h[u, i] = h1[u];
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(String.Format("{0,3}", h[i, j]));
                Console.WriteLine();
            }
        }
    }
}