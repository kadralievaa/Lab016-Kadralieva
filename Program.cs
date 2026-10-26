// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// int sum = 0;
// foreach (int grade in grades)
// {
//     sum += grade;
// }

// double average = (double)sum / grades.Length;

// Console.WriteLine($"Средний балл группы: {average:F2}");

// //2
// int[] points = { 4, 7, 2, 9, 5, 15, 20 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// //3 (Шаг 3)
// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// //4
// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }


// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] evenSlots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         evenSlots[i] = (i + 1) * 2;
//     }
//     return evenSlots;
// }

// Console.WriteLine("Обычные уроки:");
// int[] slots = GenerateScheduleSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }

// Console.WriteLine("Четные уроки:");
// int[] evenSlots = GenerateEvenSlots(6);
// foreach (int evenSlot in evenSlots)
// {
//     Console.WriteLine(evenSlot);
// }

// //5
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// //Задача А
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// int[] squares = new int[n];

// for (int i = 0; i < squares.Length; i++)
// {
//     squares[i] = (i + 1) * (i + 1);
// }

// Console.WriteLine("Массив квадратов:");
// foreach (int s in squares)
// {
//     Console.WriteLine(s);
// }

// //Задача Б
// int[] numbers = { 5, -3, 8, -1, 0, -7, 2 };

// Console.WriteLine("Исходный массив:");
// foreach (int num in numbers) Console.Write(num + " ");

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }

// Console.WriteLine("Измененный массив:");
// foreach (int num in numbers) Console.Write(num + " ");
// Console.WriteLine();


// // Индивидуальный вариант
// Console.WriteLine();
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine().Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 1
// Console.Write("Сколько чисел будете вводить? ");
// int count1 = int.Parse(Console.ReadLine());
// int[] arr1 = new int[count1];
// int sum1 = 0;

// for (int i = 0; i < arr1.Length; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     arr1[i] = int.Parse(Console.ReadLine());
//     sum1 += arr1[i];
// }

// Console.WriteLine($"Сумма всех чисел: {sum1}");

//Вариант 6
int[] arr6 = { 9, 2, 7, 4, 1, 8, 5 }; 

for (int i = 0; i < arr6.Length - 1; i++)
{
    for (int j = 0; j < arr6.Length - 1 - i; j++)
    {
        if (arr6[j] > arr6[j + 1])
        {
            int temp = arr6[j];
            arr6[j] = arr6[j + 1];
            arr6[j + 1] = temp;
        }
    }
}

int medianIndex = arr6.Length / 2;
Console.WriteLine($"Отсортированный массив: {string.Join(", ", arr6)}");
Console.WriteLine($"Медиана (средний элемент): {arr6[medianIndex]}");