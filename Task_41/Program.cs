// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите М чисел с клавиатуры");
int m = Convert.ToInt16(Console.ReadLine());
int [] a = new int[m];

void InputNumbs(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Ввести {i+1} число: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
  }
}

void WriteArray(int[] a)
{
    for (int i = 0; i<a.Length; i++ )
    {
    Console.Write("{0:0} ", a[i]);
    }
    Console.WriteLine();
}

InputNumbs(m);
WriteArray(a);

int Compare (int[] a)
{
  int count = 0;
  for (int i = 0; i < a.Length; i++)
  {
    if(a[i] > 0 ) count += 1; 
  }
  return count;
}

Console.WriteLine($"Введено чисел больше 0: {Compare(a)} ");
