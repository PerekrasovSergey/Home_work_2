// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
    
    // static bool MultiplicityNumbers(int Number)
    //     {
    //     if (Number % 7 == 0 && Number % 23 == 0 )
    //     {
    //         return true;
    //     }
    //     return false;
    //     }
    
    
    // System.Console.Write ("Input number: ");
    // int a = Convert.ToInt32(Console.ReadLine());
    // System.Console.Write(MultiplicityNumbers(a));


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

    // static int QuarterPlane(int x, int y)
    //     {
    //     int otvet = 1234;
    //     if (x > 0 && y > 0 )
    //     {
    //         otvet = 1; 
    //     }
    //     if (x < 0 && y > 0 )
    //     {
    //         otvet = 2; 
    //     }
    //     if (x < 0 && y < 0 )
    //     {
    //         otvet = 3; 
    //     }
    //     if (x > 0 && y < 0 )
    //     {
    //         otvet = 4; 
    //     }
    //     return otvet;
    //     }
    
    // System.Console.Write ("Input X coordinate: ");
    // int x = Convert.ToInt32(Console.ReadLine());
    // System.Console.Write ("Input Y coordinate: ");
    // int y = Convert.ToInt32(Console.ReadLine());


    // System.Console.Write(QuarterPlane(x, y) + " координаятная четверть");

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

    // static int CompareCharInNumbers(int Number)
    //     {
    //     int res =  Number / 10;
    //     if (Number % 10 >= Number / 10 )
    //     {
    //        res =  Number % 10;
    //     }
    //     return res;
    //     }
    
    
    // System.Console.Write ("Input number from 10 to 99: ");
    // int DoobleNumber = Convert.ToInt32(Console.ReadLine());
    // System.Console.Write(CompareCharInNumbers(DoobleNumber));

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

    // static void InputCharInNumbers(int Number)
    //     {
    //     int a = Number % 10;
    //     Number /= 10;
    //     System.Console.Write ( a );
    //     while (Number > 0)
    //     {
    //        a = Number % 10;
    //        Number /= 10;
    //        System.Console.Write ( ", " + a );
    //     }
    //     }
    
    // System.Console.Write ("Input number: ");
    // int Number = Convert.ToInt32(Console.ReadLine());
    // InputCharInNumbers(Number);

    //или 

    // static void InputCharInNumbers(int Number)
    //     {
    //     int a = Number % 10;
    //     Number /= 10;
    //     int Number2 = a;
    //     while (Number > 0)
    //     {
    //        a = Number % 10;
    //        Number /= 10;
    //        Number2 = Number2*10 + a;
    //     }
    //     a = Number2 % 10;
    //     Number2 /= 10;
    //     System.Console.Write ( a );        
    //     while (Number2 > 0)
    //     {
    //        a = Number2 % 10;
    //        Number2 /= 10;
    //        System.Console.Write ( ", " + a );
    //     }
    //     }
    
    // System.Console.Write ("Input number: ");
    // int Number = Convert.ToInt32(Console.ReadLine());
    // InputCharInNumbers(Number);