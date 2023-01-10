/*Задача 2. Напишите программу, 
которая на вход принимает позиции 
(два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или 
же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет*/


void FillArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,10);
            }
        }
}
void PrintArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }   
            Console.WriteLine();    
        }
}

Console.WriteLine("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);

int i = matrix.GetLength(0);
int j = matrix.GetLength(1); 
if(m < 0 || n < 0)
{
    Console.Write("[" + m + "," + n + "]" + "->" + "такого элемента нет");
}
else
{
    if(m >= i || n >= j)
    {
        Console.Write("[" + m + "," + n + "]" + "->" + "такого элемента нет");
    }
    else
    {
        Console.Write("[" + m + "," + n + "]" + "->" + matrix[m,n]);
    }
}