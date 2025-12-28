using System;
class ArrayClass
{
    public static void ArrayMethod()
    {
        // int[] arr1;
        // int[] arr2 = new int[5];
        // int[] arr3 = {1,2,3,4,5};
        // foreach(int x in arr3)
        // {
        //     Console.WriteLine(x);
        // }





        // int[,] mat = new int[2,3]; //this is multidimensional array which represents 2 rows and 3 col
        // int[,] mat ={{1,2,3},{4,5,6}};
        // Console.WriteLine(mat[1,0]);  // to get the particular element of 1st row and 0 col

        // for(int i = 0; i < mat.GetLength(0); i++)   // GetLength mostly used in multidimensional array(0 means row)
        // {
        //     for(int j = 0; j < mat.GetLength(1); j++)  // (1 means column) mostly used when size of row and col is fixed
        //     {
        //         Console.Write(mat[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        

        


        // int[][] jagg = new int[2][];
        // jagg[0]=new int[]{1,2};
        // jagg[1]=new int[]{3,4,5};
        // Console.WriteLine(jagg[1][2]);
        // for(int i = 0; i < jagg.Length; i++)
        // {
        //     for(int j = 0; j < jagg[i].Length; j++)
        //     {
        //         Console.Write(jagg[i][j]+" ");
        //     }
        //     Console.WriteLine();
        // }









        // int[] data = {1,2,3};
        // Array.Clear(data,1,2); // clears 2 elements in data array starting from idx 1 in the data array and make it 0
        // foreach(int x in data)
        // {
        //     Console.WriteLine(x);
        // }






        // int[] src = {1,2,3};
        // int[] dest = new int[3];
        // Array.Copy(src,dest,3); //copying top 3 elements from array src to dest
        // foreach(int x in dest)
        // {
        //     Console.WriteLine(x);
        // }





        // int[] a1 = {1,2,3};
        // Array.Resize(ref a1,6);
        // foreach(int x in a1)
        // {
        //     Console.Write(x+" ");
        // }





        // int[] a1 = {20,25,30};
        // bool ans = Array.Exists(a1,x=>x>25); //check if array contains element greater than 25 and return bool
        // Console.WriteLine(ans);












        // Merge two sorted arrays into a single sorted array.
        // Max Time: 10 minutes
        // Explanation: Demonstrates merging and sorting techniques.

        int[] arr1 = {1, 3, 5};
        int[] arr2 = {2, 4, 6};
        int[] arr3 = new int[arr1.Length+arr2.Length];
        int iss=0;
        int j=0;
        int k=0;
        while(iss< arr1.Length && j < arr2.Length)
        {
            if (arr1[iss] <= arr2[j])
            {
                arr3[k++]=arr1[iss++];
            }
            else
            {
                arr3[k++]=arr2[j++];
            }
        }
        while (iss < arr1.Length)
            arr3[k++] = arr1[iss++];
        while (j < arr2.Length)
            arr3[k++] = arr2[j++];

        foreach(var item in arr3)
        {
            Console.WriteLine(item+" ");
        }

        
    }
}