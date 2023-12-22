using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
		// создание случайного динамического одномерного массива в заданном диапазоне
		static void createRandArray(ref int[] nArray, int min, int max)
		{
			// запрос на ввод размера массива
			Console.Write("Size = ");
			// ввод размера массива
			int size = Convert.ToInt32(Console.ReadLine());
			// инициализация одномерного динамического массива
			nArray = new int[size];
			// заполнение элементов массива случайными значениями от 0 до 100
			Random rand = new Random();
			for (int i = 0; i < size; i++)
				nArray[i] = rand.Next(min, max+1);
		}

		// вывод массива на экран
		static void displayArray(int[] nArray)
		{
			// обход всех элементов массива
			for (int i = 0; i < nArray.Length; i++) {
				Console.Write(nArray[i] + " ");
			} 
		}

		// поиск заданного значения в массиве
		static bool search(int[] nArray, int value)
		{
			// обход всех элементов массива
			for (int i = 0; i<nArray.Length; i++) {
				// если текущий элемент массива совпадает с заданным значением, вернуть true
				if(value == nArray[i]) return true;
			}
			return false;// нет совпадений в массиве
		}


		// главная функция программы
		static void Main(string[] args)
        {
			int[] nArray = null;// одномерный динамический массив
			// создание случайного динамического одномерного массива в заданном диапазоне
			createRandArray(ref nArray, 0, 30);



			// бесконечный цикл ввод значений для поиска в массиве
			while (true) {
				Console.Clear();

				// вывод массива на экран
				Console.Write("Элементы массива: ");
				displayArray(nArray);
				Console.WriteLine();

				// запрос на ввод и ввод значения с клавиатуры для поиска в массиве
				Console.Write("value = ");
				int value = Convert.ToInt32(Console.ReadLine());

				// выход из бесконечного цила, если пользователь ввел -1
				if (value == -1) break;

				// поиск заданного значения в массиве
				bool result = search(nArray, value);
				// вывод результата поиска
				if (result) Console.WriteLine("Введенный элемент содержится в массиве.");
				else Console.WriteLine("Введенный элемент НЕ содержится в массиве.");

				Console.WriteLine("Нажмите любую клавишу для продолжения...");
				Console.ReadKey();// пауза окна консоли
			}

			Console.WriteLine("Конец работы программы.");
			Console.ReadKey();// пауза окна консоли
		}
    }
}
