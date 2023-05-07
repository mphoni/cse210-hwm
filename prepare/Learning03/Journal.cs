using System;

public class Journal{

    public string _storeEntry;
    public string _saveEntry;
    public string _loadEntry;
    public List<Entry> _entries = new List<Entry>();
   
    public void Display(){
        Console.WriteLine("welcome to your journal");

    }

}