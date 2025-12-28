using System;
using System.Collections;
using System.Collections.Generic;
class Collect
{
    public static void Coll()
    {
        // // List and ArrayList
        // ArrayList arr = new ArrayList();  // in c# arrayList is non generic means any data type can enter
        // arr.Add(1);
        // arr.Add("Hello");
        // arr.Add(true);
        // List<int> list = new List<int>(); // list is generic
        // list.Add(1);
        // list.Add(2);
        // list.Add(3);
        // list.Add(4);
        // for(int i=0;i<arr.Count;i++)  //.Count return size of collections
        // {
        //     Console.Write(arr[i]+" ");
        // }
        // Console.WriteLine();
        // foreach(var x in arr)  
        // {
        //     Console.Write(x+" ");
        // }
        // Console.WriteLine();
        // foreach(int x in list)
        // {
        //     Console.Write(x+" ");
        // }







        // // Dictionary and Hashtable
        // Dictionary<int, int> dict  = new Dictionary<int, int>();
        // dict.Add(1,10);
        // dict.Add(2,20);
        // dict.Add(3,30);
        // Hashtable ht = new Hashtable();
        // ht.Add(1,10);
        // ht.Add(2,20);
        // ht.Add(3,30);
        // foreach(int x in dict.Values)
        // {
        //     Console.Write(x+" ");
        // }
        // Console.WriteLine();
        // foreach(var x in ht.Values)
        // {
        //     Console.Write(x+" ");
        // }






        // // Queue(Enqueue and Dequeue)
        // Queue queue = new Queue();
        // queue.Enqueue(10);
        // queue.Enqueue(20);
        // Console.WriteLine(queue.Dequeue());
        






        // // HashSet
        // HashSet<int> set = new HashSet<int>();
        // set.Add(1);
        // set.Add(12);
        // set.Add(20);
        // set.Add(12);
        // foreach(int x in set)
        // {
        //     Console.Write(x+" ");
        // }






        // SortedList always keep data in descending
        SortedList<string, string> slist = new SortedList<string, string>();
        slist.Add("b", "B");
        slist.Add("a", "A");
        foreach(var x in slist.Reverse())
        {
            Console.WriteLine(x.Key+" "+x.Value);
        }
        Console.WriteLine(slist["a"]);







        // Dictionary<int, int> dict1  = new Dictionary<int, int>();
        // dict1.Add(1,10);
        // dict1.Add(2,20);
        // dict1.Add(3,30);
        // if (dict1.TryGetValue(1,out int value))
        // {
        //     Console.WriteLine($"For key 1 Value {value} found");
        // }
        // else
        // {
        //     Console.WriteLine("Key-Value not found");
        // }

        // foreach (KeyValuePair<int, int> emp in dict1)
        // {
        //     Console.WriteLine(emp.Key +" "+ emp.Value);
        // }
        // foreach (var emp in dict1)
        // {
        //     Console.WriteLine(emp.Key +" "+ emp.Value);
        // }

        // if (dict1.ContainsKey(1))
        // {
        //     Console.WriteLine("1 key is found");
        // }




        // Find the frequency of elements in an array using Dictionary
        int[] arr = {1,2,3,2,1,4,2};
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach(int x in arr)
        {
            if (freq.ContainsKey(x))
            {
                freq[x]+=1;
            }
            else
            {
                freq.Add(x,1);
            }
        }
        foreach(var x in freq)
        {
            Console.WriteLine($"Frequency of {x.Key} is {x.Value}");
        }
    }

}