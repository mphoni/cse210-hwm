using System;

class Program
{
    static void Main(string[] args)
    {
      Journal journal = new Journal();
        journal._storeEntry = "";
        journal._saveEntry = "";
        journal._loadEntry = "";
        journal.Display();
        
        Prompter prompter = new Prompter();
        prompter._prompts = "";
        prompter.Display();
        
        Entry entry1 = new Entry();
        entry1._notes = "what would you like to do";
        entry1._response = "write your response";

        Entry entry2 = new Entry();
        entry2._notes = "what was the best part of your day?";
        entry2._response = "write your response";
        List<Entry> enter = new List<Entry>();
        enter.Add(entry1);
        enter.Add(entry2);

        journal._entries.Add(entry1);
        journal._entries.Add(entry2);

        foreach(Entry entry in enter)
        {
        Console.WriteLine(entry2._notes);
        
       }
 
        SaveToFile(enter);
       

      List<Entry> newEnteries= ReadFromFile();
      foreach(Entry entry in enter)
      {
        Console.WriteLine(entry._response);
      }

       

    }

     public void Display(){
            
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine($"{dateText}");
        }

    public static void SaveToFile(List<Entry> enter)
    {
        Console.WriteLine("savimg to file...");
        string filename = "enter.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in enter)
            {
                outputFile.WriteLine($"{entry._notes}~~{entry._response} ");
            }
        }
    } 
    
    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("reading list form file...");
        List<Entry> enter = new List<Entry>();
        string filename = "enter.txt";


        string[] lines = System.IO.File.ReadAllLines(filename);

    foreach(string line in lines)
    {
        //Console.WriteLine(lines);

        string[] parts = line.Split("~~");


         Entry newEnteries = new Entry();
         newEnteries._notes = parts[0];
         newEnteries._response = parts[1];

        enter.Add(newEnteries);
    }
     return enter;
        
    }
}