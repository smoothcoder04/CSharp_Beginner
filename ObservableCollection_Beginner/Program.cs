using System;
//ObservableCollection class sits in this namespace
using System.Collections.ObjectModel;
// NotifyCollectionChangedEventArgs is in this namespace
using System.Collections.Specialized;

namespace ObservableCollectionNew
{
    class Program
    {
        static void Main(string[] args)
        {
            var notes = new ObservableCollection<string>();
            //CollectionChanged is the event that is part of the ObservableCollection class
            notes.CollectionChanged += Notes_CollectionChanged;
            notes.Add("I am starting my weekend");
            notes.Add("2x2=4");
            notes.Add("Hello World");
            notes.RemoveAt(2);

            //the methods that we subscribe to the event
            static void Notes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                //check what action caused the event
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine("Note with the following content was added: ");
                        Console.WriteLine(item);
                        Console.WriteLine();
                    }
                }
                if (e.Action == NotifyCollectionChangedAction.Remove ||
                    e.Action == NotifyCollectionChangedAction.Replace)
                {
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine("Note with the following content was removed: ");
                        Console.WriteLine(item);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}