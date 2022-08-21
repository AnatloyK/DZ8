//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void FillArray(int[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < columns; k++)
            {
                if(array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    PrintArray(array);
}

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(6, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    int minSum = 0; // фиксирование минимальной суммы
    int rowCount = 0; // счетчик для определения строки, в которой находится минимальная сумма
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        if(minSum == 0 || tempSum < minSum) 
        {
            minSum = tempSum;
            rowCount = i;
        }
        Console.WriteLine($"Сумма строки {i+1} = {tempSum}");
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма чисел в строке {rowCount + 1} и равна {minSum}");

}


// Задача 58. Заполните спирально массив 4 на 4.
void Zadacha58()
{
    Random random = new Random();
    int rows = random.Next(5, 11);
    int columns = random.Next(5, 11);
    int[,] array = new int[rows, columns];
    int start = 0;
    int j = 0;
    int i = 0;
    int count = 0;// счетчик для "аварийной" остановки цикла
    while(count != rows * columns)
    {
        while(j < array.GetLength(1) && array[i, j] == 0)
        {
            array[i, j] = start + 1;
            start++;
            j++;
            count++;
        }
        j--;
        i++;
        while(i < array.GetLength(0) && array[i, j] == 0)
        {
            array[i, j] = start + 1;
            start++;
            i++;
            count++;
        }
        i--;
        j--;
        while(j > -1 && array[i, j] == 0)
        {
            array[i, j] = start + 1;
            start++;
            j--;
            count++;
        }
        j++;
        i--;
        while(i > 0 && array[i, j] == 0)
        {
            array[i, j] = start + 1;
            start++;
            i--;
            count++;
        }
        i++;
        j++;
    }
    PrintArray(array);

}
// Подскажите, пожалуйста, в чем моя ошибка? Вместо циклов while я хотел вписать код в методы void StepRight, Down и тд. но получалось, 
// что в цикле работал только первый метод, остальные, как бы, проскакивались.
Zadacha58();