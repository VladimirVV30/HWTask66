// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int M, int N)
{
    int sum = M;
    if (M == N) return 0;
    else
    {
        M++;
        sum = M + SumRec(M, N);
        return sum;
    }
}

void SumNums(int M, int N)
{
    Console.Write(SumRec(M - 1, N));
}

SumNums(1, 15);
