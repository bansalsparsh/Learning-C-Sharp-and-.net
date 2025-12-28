// using System;
// using System.Collections.Generic;
// class Assign
// {
//     public static void DynamicProductPrice()
//     {
//         // Task 1
//         Console.Write("Enter the number of products: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         for(int i = 0; i < n; i++)
//         {
//             int x = Convert.ToInt32(Console.ReadLine());
//             if(x>=0) arr[i]=x;
//             else arr[i]=0;
//         }

//         int sum=0;
//         foreach(int num in arr) sum+=num;

//         int avg = sum/n;

//         Array.Sort(arr);

//         for(int i = 0; i < n; i++)
//         {
//             if(arr[i]<avg) arr[i]=0;
//         }

//         Array.Resize(ref arr,n+5);

//         Array.Fill(arr,avg,n,5);

//         for(int i = 0; i < arr.Length; i++)
//         {
//             Console.WriteLine($"Element {arr[i]} with index value {i}");
//         }
    

//         // Task 2
//         Console.Write("Enter number of Branches: ");
//         int branch = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter number of Months: ");
//         int month = Convert.ToInt32(Console.ReadLine());

//         int max=0;

//         int[,] arr = new int[branch,month];
//         for(int i = 0; i < arr.GetLength(0); i++)
//         {
//             for(int j = 0; j < arr.GetLength(1); j++)
//             {     
//                 Console.Write($"Enter value of branch{i} month{j}: ");
//                 arr[i,j] = Convert.ToInt32(Console.ReadLine());
//                 max=Math.Max(max,arr[i,j]);
//             }
//             Console.WriteLine();
//         }
//         for(int i = 0; i < arr.GetLength(0); i++)
//         {
//             int total=0;
//             for(int j = 0; j < arr.GetLength(1); j++)
//             {
//                 total+=arr[i,j];
//             }
//             Console.WriteLine($"For Branch{i} total sales are: {total}");
//         }
//         Console.WriteLine($"Highest sale value is: {max}");


//         // Task 3
//         int[][] jagged = new int[row][];
//     }
// }