using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class LargeDataCollection : IDisposable
{
    private List<string> data;
    static int totalFiles = 0;

    public LargeDataCollection(IEnumerable<string> initialData)
    {
        data = new List<string>(initialData);

        totalFiles++;

        Console.WriteLine("File Created");
        Console.WriteLine("\n# of files are: " + totalFiles);

    }

    public void Add(string element)
    {
        data.Add(element);
    }

    public bool Remove(string element)
    {
        return data.Remove(element);
    }

    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }

    public int Count => data.Count;

    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if(data!= null)
            {
                data.Clear();
                data = null;
            }
           totalFiles = 0;

        }
        Console.WriteLine($"\nFile has been disposed...");

       

    }

    ~LargeDataCollection()
    {
        Dispose(false);
    }
}



