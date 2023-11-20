// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void Sortirovka(int n){
    if (n > 0){
        System.Console.Write(n + " ");
        Sortirovka(n - 1);
    }
}

Sortirovka(8);
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
void SummNatural(int m, int n, int summ)
    {
        summ += n;
        if (n <= m)
        {
            System.Console.Write(summ);
            return;
        }
        SummNatural(m, n - 1, summ);
}

SummNatural(1, 15, 0);
*/




