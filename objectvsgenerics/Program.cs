using System;
using System.Collections;
using System.Collections.Generic;

namespace objectvsgenerics
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
  {
    public TItem Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public bool MoveNext()
    {
      throw new NotImplementedException();
    }

    public void Reset()
    {
      throw new NotImplementedException();
    }
  }

  public class Queue
  {
    private const int DEFAULTQUEUESIZE = 100;
    private object[] _data;
    private int _head = 0, _tail = 0;
    private int numElements = 0;

    public Queue()
    {
      _data = new object[DEFAULTQUEUESIZE];
    }
    public Queue(int size)
    {
      if (size > 0)
      {
        _data = new object[size];
      }
      else
      {
        throw new ArgumentOutOfRangeException("size", "must be greater than zero");
      }
    }



    public int Dequeue()
    {
      if (this.numElements == 0)
      {
        throw new Exception("Queue empty");
      }
      int queueItem = _data[_tail];
      _tail++;
      _tail %= _data.Length;
      this.numElements--;
      return queueItem;

    }
  }
}
