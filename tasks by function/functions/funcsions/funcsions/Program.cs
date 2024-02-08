void Sum(int x, int y) => Console.WriteLine($"Сумма двух чисел: {x} + {y} = {x + y}");
void Scircle(int r) => Console.WriteLine($"Площадь окружности: {r} * {2} * {3.14} = {r * 2 * 3.14}");
void line()
{
    {
        string str = "Бим-бим Бам-бам"; 
        int length = StringLength(str);
        Console.WriteLine($"Длина строки: {length}"); 
    }

    int StringLength(string input)
    {
        return input.Length;
    }
}
void ArrayMax()
{
{
    int[] arr = { 1, 9, 2, 8, 3, 7, 4, 6 };
    int max = Max(arr);
    Console.WriteLine($"Наибольшее значение массива: {max}");
}

int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
}
void Factoriаl(int f)
{
{
    
    long factorial = Factorial(f);
    Console.WriteLine($"Факториал числа: {factorial}");
}

long Factorial(int f)
{
    if (f == 0) return 1;
    return f * Factorial(f - 1);
}
}
void ItsPalindrome()
{
    {
        string str1 = "дед";
        bool Palindrome1 = Palindrome(str1);
        Console.WriteLine($"Является палиндромом?: {str1} - {Palindrome1}");

        string str2 = "недед";
        bool Palindrome2 = Palindrome(str2);
        Console.WriteLine($"Является палиндромом?: {str2} - {Palindrome2}");
    }

    bool Palindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;
        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
void ConnectedArray()
{
    {
        int[] arr1 = { 1, 3, 5 };
        int[] arr2 = { 2, 4, 6 };
        int[] result = MergeArrays(arr1, arr2);
        Console.WriteLine($"Итог объеденения массивов: {string.Join(", ", result)}");
    }

int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, result, arr1.Length);
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        return result;
    }
}
void PrimeNumber(int num1, int num2)
{
{
    bool isPrime1 = IsPrime(num1);
    Console.WriteLine($"Является ли число {num1} простым? {isPrime1}");

    bool isPrime2 = IsPrime(num2);
    Console.WriteLine($"Является ли число {num2} простым? {isPrime2}");
}

bool IsPrime(int num)
{
    if (num <= 1) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false;
    for (int i = 3; i * i <= num; i += 2)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
}
void ReverseStr(string str1)
{
{
    string reversed = ReverseString(str1);
    Console.WriteLine(reversed);
}

string ReverseString(string input)
{
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}
}
void ArraysSum()
{
    {
        int[,] arr = { { 4, 8, 1 }, { 7, 6, 2 }, { 3, 5, 9 } };
        int sum = SumArray(arr);
        Console.WriteLine($"Сумма всех чисел матрицы: {sum} ");
    }

    int SumArray(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
}






    Sum(5, 10); // сумма 2-х чисел

    Scircle(5); //S окружности

    line(); //Длина строки

    ArrayMax(); //Наибольшее значение массива

    Factoriаl(7); //Факториал числа

    ItsPalindrome(); //Палиндромы

    ConnectedArray(); //Объеденённые массивы

    PrimeNumber(5, 4); //Простое число

    ReverseStr("Это работает?"); //Строка наоборот

    ArraysSum(); //Сумма всех элементов двумерного массива