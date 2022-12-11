// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
int FindDegreeNumbers (int arg1, int arg2)
{   
     int result = 0;
     int N = arg1;

    for(int i = 1; i  < arg2; i++)
    { 
        N = N*arg1;
        result = N;
    }
    return result;
}

Console.WriteLine("Ведите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int end = FindDegreeNumbers(num1,num2);
Console.WriteLine(end);


