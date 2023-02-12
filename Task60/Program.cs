/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/



Dictionary<int, int> GetDictionery(int[,,] matrix)
{
    Dictionary<int, int> Slovar = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                if (Slovar.ContainsKey(matrix[i, j, z]))
                {
                    Slovar[matrix[i, j, z]] = Slovar[matrix[i, j, z]] + 1;
                }
                else
                {
                    Slovar.Add(matrix[i, j, z], 1);
                }
            }
        }

    }
    return Slovar;
}

bool GetCheker(int[,,] matrix, Dictionary<int, int> Slovar)
{
    bool temp = true;
    foreach (var item in Slovar)
    {
        if (item.Value > 1)
        {
            temp = false;
        }
    }
    return temp;
}




int[,,] Generate3DArray(int m, int n, int o)
{

    int[,,] result = new int[m, n, o];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int z = 0; z < result.GetLength(2); z++)

            {
                result[i, j, z] = new Random().Next(1, 100);
            }
        }

    }
    return result;
}
void Print3DArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)

            {
                if (arr[i, j, z] < 10) Console.Write($"  0{arr[i, j, z]}({i},{j},{z})");
                else Console.Write($"  {arr[i, j, z]}({i},{j},{z})");
            }
            Console.WriteLine();
        }
    }

}

int[,,] matrix = Generate3DArray(2, 2, 2);
Dictionary<int, int> SlovarDic = GetDictionery(matrix);
while (true)
{
    if (GetCheker(matrix, SlovarDic))
    {
        break;
    }
    else
    {
        matrix = Generate3DArray(2, 2, 2);
        SlovarDic = GetDictionery(matrix);
    }
}


Print3DArray(matrix);
Console.WriteLine();
