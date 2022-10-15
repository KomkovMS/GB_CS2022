/*
Показать сколько каких элементов присутствует в массиве

// {1,2,1,1,1,1,2,2,2,3,3,3,3}

// 1 - 5 раз
// 2 - 4 раза и т.д.

*/

// int n = Random.Shared.Next(1, 100); // 10<= n <= 1000
// // int[]arr = new int[n]; // 0 .. 100

// int[]arr = Enumerable.Range(0, n)
//                     .Select(e => Random.Shared.Next(0, 20))
//                     .ToArray();

// Console.WriteLine(String.Join(" ", arr));
// Console.WriteLine(arr.Length);

// int count1 = 0;
// int count2 = 0;
// int count3 = 0;
// for (int i = 0; i < (arr.Length - 1); i++)
// {
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[i] == count3)
//         {
//             continue;
//         }
//     }
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             count1++;
//             count2++;
//             count3 = arr[i];
//         }
//     }
//     if (count1 > 0)
//     {

//          Console.WriteLine($"{arr[i]} повторяется в массиве {count1} раз");
//     }
// }



// НЕОБХОДИМО ВЕРНУТЬ К РЕШЕНИЮ ЗАДАЧИ





