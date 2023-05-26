// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];
for (int i = 0; i < n; i++)
{
  Console.Write($"Введите строку {i + 1}: ");
  array[i] = Console.ReadLine();
}

string[] newArray = FilterArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("Массив с элементами длиной не более 3 символов:");
PrintArray(newArray);

string[] FilterArray(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      count++;
    }
  }

  string[] newArray = new string[count];
  int index = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      newArray[index] = array[i];
      index++;
    }
  }

  return newArray;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"\"{array[i]}\"");
    if (i != array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}
