// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 // [345, 897, 568, 234] -> 2

// Console.Clear();
// Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
// int[] numbers = new int[10];

// void FillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void WriteArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int QuantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// FillArray(numbers, 100, 1000);
// WriteArray(numbers);
// Console.WriteLine();

// int quantity = QuantityPositive(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


 // Console.Clear();
// Console.WriteLine($"\nЗадача 36. Сумма элементов, стоящих на нечётных позициях:\n");
// Console.Write($"Введи количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// Console.WriteLine("Задача №37: 'произведение пар чисел в одномерном массиве.'");
// Console.WriteLine("");
// int[] myarray3 = MyArray(new Random().Next(5, 15), -10, 99);
// int[] resarray = MultiResultArray(myarray3);
// Console.WriteLine("");
// Console.WriteLine("Новый массив с результатом произведения пар основного массива:");
// PrintArray(resarray);
// int[] MultiResultArray(int[] array){
//     int[] myarray = ArrayReverse(array);
//     if(array.Length % 2 == 0){
//         int[] resultarray = new int[array.Length / 2];
//          for(int i = 0; i < array.Length / 2; i++){
//             resultarray[i] = array[i] * myarray[i];
//         }
//         return resultarray;
//     }
//     else{
//         int[] resultarray = new int[array.Length / 2 + 1];
//          for(int i = 0; i < array.Length / 2; i++){
//             resultarray[i] = array[i] * myarray[i];
//         }
//          resultarray[array.Length / 2] = myarray[array.Length / 2];
//          return resultarray;
//     }
// }
// int[] ArrayReverse(int[] array){
//     int[] myarray = new int[array.Length];
//     int j = array.Length - 1;
//     for(int i = 0; i < array.Length; i++){
//         myarray[i] = array[j];
//         j--;
//     }
//     return myarray;
// }