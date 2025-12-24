using System;
using LibrarySystem;
class Store
{
    public List<LibraryItem> list = new List<LibraryItem>();
    public void StoreList(LibraryItem obj)
    {
        list.Add(obj);
    }
}