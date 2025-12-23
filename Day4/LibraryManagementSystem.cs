using System;
class Library
{
    // Creating Data Structure(Map with key value pairs);
    private Dictionary<int,string> book = new Dictionary<int,string>();
    public string this[int id]
    {
        get{return book.ContainsKey(id)?book[id]:"Book not found!";}
        set{book[id]=value;}
    }
    public int this[string name]
    {
        get
        {
            // .Key returns the key matching with the value and .Value will return the first matching value in the dictionary
            return book.FirstOrDefault(e=>e.Value==name).Key;
        }
    }
}