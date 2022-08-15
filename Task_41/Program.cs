// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

        void CountNumMoreZero()
        {
            Console.Write("Введите числа через пробел: ");
            string[] arr = Console.ReadLine().Split();

            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(int.Parse(arr[i]) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во элементов больше 0: {count}");
        }
        CountNumMoreZero();
