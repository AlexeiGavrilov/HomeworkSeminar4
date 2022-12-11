int GetLengthOfNumber(int val)  
{

    int count = 0;
    while(val > 0)
    {
      val = val / 10;
      count++; //количество цифр
    }
    return count;
}
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 452 -> 6
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int lenght = GetLengthOfNumber(num);
int [] array = new int[lenght];
int numbers = num;
int sum =0;
for (int i=0; i < lenght; i++)
{
    array[i] = num % 10;
    num = num / 10;
}

for (int j = 0; j < array.Length; j++)
{   
    int N = numbers % array [j];
    if(N==0)
    {
      sum= sum + array[j];
    }
}
Console.WriteLine(sum);






