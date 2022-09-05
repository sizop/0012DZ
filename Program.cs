// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8"

/*
Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

string numbers(int M, int N)
{
	if (M == N) return M.ToString();
	return (M + ", " + numbers((M + 1), N));
}
Console.WriteLine($"Числа до {N}: {numbers(M, N)}");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers(int M, int N)
{
	if (M == N) return M;
	return (M + numbers((M + 1), N));
}
Console.WriteLine($"Числа до {N}: {numbers(M, N)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите первое число (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman(int m, int n)
{
	if (m == 0) return (n + 1);
	if (n == 0) return (functionAkkerman(m - 1, 1));
	else return (functionAkkerman(m - 1, functionAkkerman(m, n - 1)));
}

Console.WriteLine($"Результат расчета функции Аккермана составил - {akerman(m,n)}");